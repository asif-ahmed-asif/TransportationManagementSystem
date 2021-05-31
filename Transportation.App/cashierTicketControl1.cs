using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class cashierTicketControl1 : UserControl
    {
        private List<Route> RouteList;
        private Route Route { get; set; }
        public cashierTicketControl1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!this.Validation())
            {
                return;
            }

            cashierTicketControl2 second = new cashierTicketControl2();
            MainControl.showControl(second, frmCashierDashboard.ActiveForm);
           
        }

        private bool Validation()
        {
            this.Route = new Route
            {
                DeptLocation = this.cboFrom.Text,
                Destination = this.cboTo.Text,
                BusType = this.cmbBusType.Text
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


        private void cashierTicketControl1_Load(object sender, EventArgs e)
        {
            try
            {
                this.RouteList = RouteRepo.GetAll();
                foreach (var route in this.RouteList)
                {
                    this.cboFrom.Items.Add(route.DeptLocation);
                    this.cboTo.Items.Add(route.Destination);
                }
                    
            }
            catch (Exception error)
            {
                MessageBox.Show($"Error fetching data\n{error.Message}");
            }

        }
    }
}
