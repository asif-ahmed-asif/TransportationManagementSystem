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

namespace Transportation.App
{
    public partial class cashierTicketControl2 : UserControl
    {
        public cashierTicketControl2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cashierTicketControl1 firstControl = new cashierTicketControl1();
            MainControl.showControl(firstControl, frmCashierDashboard.ActiveForm);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            cashierTicketControl3 third = new cashierTicketControl3();

            frmSeatVIew seat = new frmSeatVIew();
            DialogResult result = seat.ShowDialog();
            if(result== DialogResult.OK)
                MainControl.showControl(third, frmCashierDashboard.ActiveForm);

        }

        private void cashierTicketControl2_Load(object sender, EventArgs e)
        {
            try
            {
                this.dgvCashierSchedule.AutoGenerateColumns = false;
                this.dgvCashierSchedule.DataSource = TicketRepo.getSchedule(MainControl.cashierFrom, MainControl.cashierTo, MainControl.cashierBusType,MainControl.cashierJourneyDate);
                this.dgvCashierSchedule.ClearSelection();
                this.dgvCashierSchedule.Refresh();
            }
            catch (Exception grid)
            {
                MessageBox.Show("Error fetching gridview data!" + grid.Message);
            }
            
        }
        private void dgvCashierSchedule_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.dgvCashierSchedule.ClearSelection();
        }

        private void dgvCashierSchedule_DoubleClick(object sender, EventArgs e)
        {
            MainControl.scheduleId = this.dgvCashierSchedule.CurrentRow.Cells["schedule_id"].Value.ToString();

            cashierTicketControl3 third = new cashierTicketControl3();

            frmSeatVIew seat = new frmSeatVIew();
            DialogResult result = seat.ShowDialog();
            if (result == DialogResult.OK)
                MainControl.showControl(third, frmCashierDashboard.ActiveForm);
        }
    }
}
