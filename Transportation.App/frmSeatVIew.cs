using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transportation.Repository;
using Transportation.Entity;

namespace Transportation.App
{
    public partial class frmSeatVIew : Form
    {
        private string selectedSeats = "";
        private int selectedSeatCount = 0;
        private int availableSeatCount = 0;
        private string scheduleId = "";

        private Booking Booking { get; set; }
        public frmSeatVIew()
        {
            InitializeComponent();
        }


        private void btnConfirm_Click(object sender, EventArgs e)
        {
            
        }

        private void frmSeatVIew_Load(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {

                if (c.GetType() == typeof(Button))
                {

                    
                     if (c.Name != "btnConfirm")
                         c.Click+=buttonClick;
                }
            }

            this.FillEntity();
            string bookedSeatNames=BookingRepo.GetBookedSeats(Booking.ScheduleId, Booking.JourneyDate);
            string[] bookedSeatNamesArray = bookedSeatNames.Split(',');
          //  MessageBox.Show(bookedSeatNamesArray[0]);

            foreach (Control c in this.Controls)
            {

                if (c.GetType() == typeof(Button))
                {


                    if (c.Name != "btnConfirm")
                    {
                        foreach (string s in bookedSeatNamesArray)
                        {
                          //  MessageBox.Show(c.Name);
                          //  MessageBox.Show(s);
                          //  break;
                            if (c.Text == s)
                            {

                                c.Enabled = false;
                                c.BackColor = Color.FromArgb(237, 193, 123);
                                c.ForeColor = Color.White;
                                    
                                
                            }

                        }
                    }
                }
            }


        }

        private void buttonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if(button.BackColor != Color.FromArgb(91, 123, 227))
            {
                button.BackColor = Color.FromArgb(91, 123, 227);
                button.ForeColor = Color.White;
            }
            else
            {
                
                button.BackColor = SystemColors.ControlLight;
                button.ForeColor = SystemColors.ControlText;
            }
        }

        private void btnConfirm_Click_1(object sender, EventArgs e)
        {
            
            foreach (Control c in this.Controls)
            {

                if (c.GetType() == typeof(Button))
                {


                    if (c.BackColor == Color.FromArgb(91, 123, 227))
                        if (selectedSeatCount > 0)
                        {
                            selectedSeats += "," + c.Text;
                            selectedSeatCount++;
                        }
                        else
                        {
                            selectedSeats += c.Text;
                            selectedSeatCount++;
                        }
                }
            }

            this.FillEntity();
            try
            {
                
                if (BookingRepo.Save(this.Booking))
                {
                    MessageBox.Show("Booking data saved");
                }

            }
            catch (Exception save)
            {
                MessageBox.Show("Can not save into Booking Table" + save.Message);
            }


        }

        private void FillEntity()
        {
            try
            {
                string[] id = TicketRepo.getRouteAndBusId(MainControl.cashierFrom, MainControl.cashierTo, MainControl.cashierBusType);
                string routeId = id[0]; //route id is on the index 0
                scheduleId = ScheduleRepo.GetScheduleId(routeId);
                availableSeatCount = 37 - selectedSeatCount;


            }
            catch (Exception id)
            {
                MessageBox.Show("Error fetching Schedule ID" + id.Message);
            }

            this.Booking = new Booking()
            {
                JourneyDate = MainControl.cashierJourneyDate,
                Seats = selectedSeats,
                AvailableSeatCount = availableSeatCount,
                ScheduleId = scheduleId
            };

        }
    }
}
