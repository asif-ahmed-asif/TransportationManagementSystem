using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FluentValidation.Results;
using Transportation.Entity;
using Transportation.Repository;
using Transportation.Validation;

namespace Transportation.App
{
    public partial class controlRoute : UserControl
    {
        private Route Route { get; set; }
        
        public controlRoute()
        {
            InitializeComponent();
        }

        private void controlRoute_Load(object sender, EventArgs e)
        {
            this.FillDropDownFromDb();
            this.GenerateRouteId();
            this.FillRouteDataGridView();
        }

        private void FillDropDownFromDb() //Used to Fill the Drop Down List with bus_no
        {
            List<Bus> buses = BusRepo.GetAll();
            int i;
            
            for (i= 0; i < buses.Count; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    this.cmbBus.Items.Add(buses[i].BusNo);
                }
            }
        }

        private void GenerateRouteId()
        {
            this.disableBusIdText.Text = RouteRepo.GetId();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            bool idExist = RouteRepo.SearchRouteId(this.disableBusIdText.Text);
            if (idExist) //For Update purpose
            {
                if (!this.RouteFill())
                {
                    return;
                }
                else
                {
                    Entity.Schedule schedule = new Entity.Schedule();
                    schedule.ScheduleId = this.invisibleScheduleIdText.Text;
                    schedule.DeptTime = this.dateTimePicker1.Text;
                    schedule.ArrivalTime = this.dateTimePicker2.Text;

                    bool updateScheduleSignal = ScheduleRepo.Update(schedule);

                    Route.Status = this.routeStatus.Text;
                    bool updateRouteSignal = RouteRepo.Update(this.Route);
                    if (updateRouteSignal && updateScheduleSignal)
                    {
                        MessageBox.Show("Route Updated Successuflly!!");
                        this.ClearRouteInput();

                        //Once the save button is clicked for edit, new Id, as primary key, will be generated for the route table.
                        this.disableBusIdText.Text = RouteRepo.GetId();
                        this.FillRouteDataGridView();
                    } 
                }
            }
            if (!idExist) //for insert purpose
            {
                if (!this.RouteFill())
                {
                    return;
                }
                else if (this.RouteFill())
                {
                    //First we have to insert data into schedule table and then to route table
                    Entity.Schedule schedule = new Entity.Schedule();
                    schedule.ScheduleId = ScheduleRepo.GetId();
                    schedule.DeptTime = this.dateTimePicker1.Text;
                    schedule.ArrivalTime = this.dateTimePicker2.Text;

                    this.Route.ScheduleId = schedule.ScheduleId; //In Route table schedule_id is a foreign key.

                    bool insertSignalSchedule = ScheduleRepo.Insert(schedule); //inserting into schedule table
                    
                    bool insertSignal = RouteRepo.Insert(this.Route); //inserting into the route table
                    if (insertSignal && insertSignalSchedule)
                    {
                        MessageBox.Show("Route Created Successuflly!!");
                        this.ClearRouteInput();

                        //Once the save button is clicked, new Id, as primary key, will be generated for the route table.
                        this.disableBusIdText.Text = RouteRepo.GetId();
                        this.FillRouteDataGridView();
                    }
                }
            }
        }

        private bool RouteFill()
        {
            this.Route = new Route
            {
                RouteId = this.disableBusIdText.Text,
                DeptLocation = this.departureText.Text,
                Destination = this.richTextBox1.Text,
                BusNo = this.cmbBus.Text,
                Status = "Active"
            };
            
            RouteValidation routeValidation = new RouteValidation();
            ValidationResult validationResult = routeValidation.Validate(this.Route);
            
            IList<ValidationFailure> failures = validationResult.Errors;

            if (!validationResult.IsValid)
            {
                foreach (ValidationFailure failure in failures)
                {
                    MessageBox.Show(failure.ErrorMessage, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return false;
                }
            }

            return true;
        }

        private void ClearRouteInput()
        {
            this.departureText.Text = "";
            this.richTextBox1.Text = "";
            this.cmbBus.SelectedIndex = -1;
            this.changeStatusBtn.Visible = false;
            this.routeStatus.Visible = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearRouteInput();
            this.FillRouteDataGridView();
        }

        private void rtxtSearch_TextChanged(object sender, EventArgs e)
        {
            this.dgvRoute.AutoGenerateColumns = false;
            this.dgvRoute.DataSource = RouteRepo.LiveSearchRoutes(this.rtxtSearch.Text);
            this.dgvRoute.ClearSelection();
            this.dgvRoute.Refresh();
        }

        private void dgvRoute_DoubleClick(object sender, EventArgs e)
        {
            this.changeStatusBtn.Visible = true;
            this.routeStatus.Visible = true;
            this.routeStatus.Text = this.dgvRoute.CurrentRow.Cells[7].Value.ToString();;
            
            this.departureText.Text = this.dgvRoute.CurrentRow.Cells[2].Value.ToString();
            this.richTextBox1.Text = this.dgvRoute.CurrentRow.Cells[3].Value.ToString();
            this.cmbBus.Text = this.dgvRoute.CurrentRow.Cells[6].Value.ToString();
            this.dateTimePicker1.Text = this.dgvRoute.CurrentRow.Cells[4].Value.ToString();
            this.dateTimePicker2.Text = this.dgvRoute.CurrentRow.Cells[5].Value.ToString();
            this.disableBusIdText.Text = this.dgvRoute.CurrentRow.Cells[0].Value.ToString();
            this.invisibleScheduleIdText.Text = this.dgvRoute.CurrentRow.Cells[1].Value.ToString();
        }

        private void FillRouteDataGridView()
        {
            this.dgvRoute.AutoGenerateColumns = false;
            this.dgvRoute.DataSource = RouteRepo.ShowAll();
            this.dgvRoute.ClearSelection();
            this.dgvRoute.Refresh();
        }

        private void changeStatusBtn_Click(object sender, EventArgs e)
        {
            if (this.routeStatus.Text == "Active")
            {
                this.routeStatus.Text = "Inactive";
            }
            else if (this.routeStatus.Text == "Inactive")
            {
                this.routeStatus.Text = "Active";
            }
        }

        private void dgvRoute_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.dgvRoute.ClearSelection();
        }

        private void cmbBus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
