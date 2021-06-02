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
    public partial class cashierTicketControl3 : UserControl
    {
        private Ticket Ticket { get; set; }
        public cashierTicketControl3()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cashierTicketControl2 second = new cashierTicketControl2();
            MainControl.showControl(second, frmCashierDashboard.ActiveForm);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (!this.FillEntity())
                return;
            this.ClearUserInput();
        }

        private bool FillEntity()
        {
            this.Ticket = new Ticket
            {
                CustomerName = this.txtName.Text,
                CustomerPhone = this.txtPhnNumber.Text
            };

            TicketValidation ticketValidation = new TicketValidation();
            ValidationResult validationResult = ticketValidation.Validate(this.Ticket);

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

        private void ClearUserInput()
        {
            this.txtName.Text = "";
            this.txtPhnNumber.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmPrintedTicket printT= new frmPrintedTicket();
            printT.Show();
            
        }
    }
}
