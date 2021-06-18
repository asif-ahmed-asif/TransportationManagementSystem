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
        private Ticket Ticket { get; set; }
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
          /*  string id=TicketRepo.getRouteId(this.Route.DeptLocation, this.Route.Destination, this.Route.BusType);
            MessageBox.Show(id);*/
            cashierTicketControl2 second = new cashierTicketControl2();
            MainControl.showControl(second, frmCashierDashboard.ActiveForm);
           
        }

        private bool Validation()
        {
            
            this.Ticket = new Ticket
            {
                DeptLocation = this.cboFrom.Text,
                Destination = this.cboTo.Text,
                BusType = this.cmbBusType.Text
            };

            CashierValidation cashierValidation = new CashierValidation();
            ValidationResult validationResult = cashierValidation.Validate(this.Ticket);

            IList<ValidationFailure> failures = validationResult.Errors;

            if (!validationResult.IsValid)
            {
                foreach (ValidationFailure failure in failures)
                {
                    MessageBox.Show(failure.ErrorMessage, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return false;
                }
            }
            MainControl.cashierBusType = this.Ticket.BusType;
            MainControl.cashierFrom = this.Ticket.DeptLocation;
            MainControl.cashierTo = this.Ticket.Destination;
            MainControl.cashierJourneyDate = dateTimePicker1.Value.ToString("yyyy/MM/dd");

            return true;
        }


        private void cashierTicketControl1_Load(object sender, EventArgs e)
        {
            this.dateTimePicker1.MinDate = DateTime.Now;
            this.dateTimePicker1.MaxDate = this.dateTimePicker1.Value.AddDays(30);

            try
            {

                string[] deptLocationList=RouteRepo.GetAllDeptLocation();
                foreach (string s in deptLocationList)
                {
                    this.cboFrom.Items.Add(s);
                }
                    
            }
            catch (Exception error)
            {
                MessageBox.Show($"Error fetching data\n{error.Message}");
            }
            

            this.cboFrom.Text = MainControl.cashierFrom;
            this.cboTo.Text = MainControl.cashierTo;
            this.cmbBusType.Text = MainControl.cashierBusType;
        }

        private void cboFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cboTo.Items.Clear();
            try
            {
                this.RouteList = RouteRepo.GetAllDestination(this.cboFrom.Text);
                foreach (var route in this.RouteList)
                {
                    this.cboTo.Items.Add(route.Destination);
                }

            }
            catch (Exception error)
            {
                MessageBox.Show($"Error fetching data\n{error.Message}");
            }
        }

        private void cboTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] bustypes = BusTypeRepo.GetBusTypeByRoute(this.cboFrom.Text,this.cboTo.Text);
            this.cmbBusType.Items.Clear();
            foreach (string s in bustypes)
            {
                this.cmbBusType.Items.Add(s);
            }
        }

        private void cmbBusType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
