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
    public partial class frmCashierDashboard : Form
    {
        public frmCashierDashboard()
        {
            InitializeComponent();
            this.pnlRed.Height = this.btnHome.Height;
            cashierTicketControl1 firstControl = new cashierTicketControl1();
            MainControl.showControl(firstControl, this);

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.pnlRed.Height = this.btnHome.Height;
            this.pnlRed.Top = this.btnHome.Top;


            cashierTicketControl1 firstControl = new cashierTicketControl1();
            MainControl.showControl(firstControl, this);


        }

        public  void showControl(Control control)
        {
            
            pnlControl.Controls.Clear();
            //Controls.Clear();

            pnlControl.Controls.Add(control);
            control.Location = new Point()
            {
                X = pnlControl.Width / 2 - control.Width / 2,
                Y = pnlControl.Height / 2 - control.Height / 2
            };

            /* control.Dock = DockStyle.Fill;
             control.BringToFront();
             control.Focus();

             Controls.Add(control);*/
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            this.pnlRed.Height = this.btnProfile.Height;
            this.pnlRed.Top = this.btnProfile.Top;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

       

        private void frmCashierDashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to logout?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.No)
                return;

            frmLogin login = new frmLogin();
            login.Show();
            this.Visible = false;
        }

        /* private void SetPanelPosition(object button)
{
this.pnlRed.Height = button.Height;
this.pnlRed.Top = this.btnProfile.Top;
} */
    }
}
