using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
