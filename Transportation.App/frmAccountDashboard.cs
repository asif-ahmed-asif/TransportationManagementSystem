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
    public partial class frmAccountDashboard : Form
    {
        public frmAccountDashboard()
        {
            InitializeComponent();
            this.pnlRed.Height = this.btnCost.Height;


            controlAccount1 account = new controlAccount1();
            MainControl.showControl(account, this);

        }

       

        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


       

        private void btnCost_Click(object sender, EventArgs e)
        {
            this.pnlRed.Height = this.btnCost.Height;
            this.pnlRed.Top = this.btnCost.Top;

            controlAccount1 account = new controlAccount1();
            MainControl.showControl(account, frmAccountDashboard.ActiveForm);
        }

        private void frmAccountDashboard_Load(object sender, EventArgs e)
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
