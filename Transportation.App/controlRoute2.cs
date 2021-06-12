using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transportation.Entity;
using Transportation.Repository;

namespace Transportation.App
{
    public partial class controlRoute2 : UserControl
    {
        private Route Route { get; set; }
        public controlRoute2()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            controlRoute route = new controlRoute();
            MainControl.showControl(route, frmAdminDashboard.ActiveForm);
        }

        private void controlRoute2_Load(object sender, EventArgs e)
        {
            this.FillDropDownFromDb();
        }


        private void FillDropDownFromDb() //Used to Fill the Drop Down List with bus_no
        {
            try
            {
                string[] buses = BusRepo.GetUnassignedBuses();
                


                foreach (string s in buses)
                {
                    this.cmbBusNo.Items.Add(s);
                    
                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong in drop down!" + e);
            }
        }

        private void cmbBusNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string[,] info = RouteRepo.GetRouteAndSchedule(this.cmbBusNo.Text);
                //departure location info[][0]
                //destination info[][1]
                //departure time info[2]
                //arrival info[3]

                this.txtFrom.Text = info[0, 0];
                this.txtDestination.Text = info[0, 1];
                this.txtDeptTime.Text = info[0, 2];
                this.txtArrivalTime.Text = info[0, 3];
                this.txtReturnFrom.Text = this.txtDestination.Text;
                this.txtReturnDestination.Text = this.txtFrom.Text;

                this.invisibleFareTextField.Text = info[0, 4];
            }

            catch (Exception f)
            {
                Console.WriteLine("Something went wrong when fetching data" + e);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("fdsf");
            //First we have to insert data into route table and then into the schedule table
            this.RouteFill();
            
            Entity.Schedule schedule = new Entity.Schedule();
            try
            {
                schedule.ScheduleId = ScheduleRepo.GetId();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }

            schedule.DeptTime = this.dtpDeparture.Text;
            schedule.ArrivalTime = this.dtpArrival.Text;
            schedule.RouteId = this.Route.RouteId; //In Schedule table route_id is a foreign key.

            try
            {
                RouteRepo.Insert(this.Route); //inserting into the route table
                ScheduleRepo.Insert(schedule); //inserting into schedule table

                MessageBox.Show("Created Successfully");
                
                //After inserting data the route home page will be redirected
                controlRoute route = new controlRoute();
                MainControl.showControl(route, frmAdminDashboard.ActiveForm);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Something went wrong when inserting schedule");
            }
        }

        private void RouteFill()
        {
            try
            {
                this.Route = new Route
                {
                    RouteId = RouteRepo.GetId(),
                    DeptLocation = this.txtReturnFrom.Text,
                    Destination = this.txtReturnDestination.Text,
                    BusNo = this.cmbBusNo.Text,
                    Fare = this.invisibleFareTextField.Text,
                    BusType = "01",
                    Status = "Active"
                };
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong when getting Route Information!");
            }
        }
    }
}
