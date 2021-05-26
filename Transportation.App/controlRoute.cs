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
        }

        void FillDropDownFromDb()
        {
            DataTable dataTable = BusRepo.GetAll();
            int i;
            for (i= 0; i < dataTable.Rows.Count; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    this.cmbBus.Items.Add(dataTable.Rows[i][j].ToString());
                }
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            /*throw new System.NotImplementedException();*/
            if (!this.RouteFill())
            {
                return;
            }
            else if(this.RouteFill())
            {
                
            }
            
        }

        public bool RouteFill()
        {
            this.Route = new Route
            {
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
    }
}
