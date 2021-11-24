﻿using System;
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
        private Booking booking = new Booking();
        private int selectedSeatCount = 0;

        
        public cashierTicketControl3()
        {
            InitializeComponent();
            this.selectedSeatCount = MainControl.selectedSeatCount;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cashierTicketControl2 second = new cashierTicketControl2();
            MainControl.showControl(second, frmCashierDashboard.ActiveForm);
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
            if (!this.FillEntity())
                return;

            Ticket ticket = new Ticket();
            ticket.CustomerName = this.txtName.Text;
            ticket.CustomerPhone = this.txtPhnNumber.Text;
            ticket.JourneyDate = MainControl.cashierJourneyDate;
            ticket.SeatNo = MainControl.booking.Seats;
            ticket.ScheduleId = MainControl.booking.ScheduleId;
            ticket.Fare = TicketRepo.GetFare(ticket.ScheduleId);
            ticket.TotalFare = (int.Parse(ticket.Fare) * MainControl.selectedSeatCount).ToString();
            this.booking= MainControl.booking;
            try
            {
                BookingRepo.Save(this.booking);
            }
            catch (Exception save)
            {
                MessageBox.Show("Can not save into Booking Table" + save.Message);
            }

            try
            {
                TicketRepo.Insert(ticket);
                this.SaveSalesAmount(ticket.ScheduleId);
                frmPrintedTicket printT = new frmPrintedTicket();
                printT.Phone = this.txtPhnNumber.Text;
                printT.Show();
                this.ClearUserInput();

            }
            catch (Exception save)
            {
                MessageBox.Show("Can not save into Ticket Table" + save.Message);
            }
            
        }

        private void SaveSalesAmount(string scheduleId)
        {
            try
            {
                string routeId = ScheduleRepo.GetRouteId(scheduleId);
                int ticketPrice = RouteRepo.GetFare(routeId);
                int currentSalesAmount = SalesRepo.CurrentSalesAmount(MainControl.cashierId);
                if(currentSalesAmount == 0)
                {
                    int amount = ticketPrice * MainControl.selectedSeatCount;
                    SalesRepo.Insert(MainControl.cashierId, amount);
                }
                else
                {
                    int updatedAmount = currentSalesAmount + (ticketPrice * MainControl.selectedSeatCount);
                    SalesRepo.Update(MainControl.cashierId, updatedAmount);
                }
                
            }catch(Exception e)
            {
                MessageBox.Show("Error!" + e.Message);
            }
        }
    }
}
