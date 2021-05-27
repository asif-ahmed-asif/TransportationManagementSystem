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
            FillDropDownFromDb();
            GenerateRouteId();
        }

        void FillDropDownFromDb() //Used to Fill the Drop Down List with bus_no
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

        void GenerateRouteId()
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
                    bool insertSignal = RouteRepo.Update(this.Route);
                    if (insertSignal)
                    {
                        MessageBox.Show("Route Updated Successuflly!!");
                        ClearRouteInput();

                        //Once the save button is clicked for edit, new Id, as primary key, will be generated for the route table.
                        this.disableBusIdText.Text = RouteRepo.GetId();
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
                    bool insertSignal = RouteRepo.Insert(this.Route);
                    if (insertSignal)
                    {
                        MessageBox.Show("Route Created Successuflly!!");
                        ClearRouteInput();

                        //Once the save button is clicked, new Id, as primary key, will be generated for the route table.
                        this.disableBusIdText.Text = RouteRepo.GetId();
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
            this.cmbBus.Text = null;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearRouteInput();
        }

        private void rtxtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvUser_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
