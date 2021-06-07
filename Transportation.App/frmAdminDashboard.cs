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
    public partial class frmAdminDashboard : Form
    {
        public frmAdminDashboard()
        {
            InitializeComponent();
            this.pnlRed.Height = this.btnHome.Height;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.pnlRed.Height = this.btnHome.Height;
            this.pnlRed.Top = this.btnHome.Top;
            
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


            controlUser user = new controlUser();
            MainControl.showControl(user, frmAdminDashboard.ActiveForm);

        }

        private void frmAdminDashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnBus_Click(object sender, EventArgs e)
        {
            this.pnlRed.Height = this.btnBus.Height;
            this.pnlRed.Top = this.btnBus.Top;

            controlBus bus = new controlBus();
            MainControl.showControl(bus, frmAdminDashboard.ActiveForm);
        }

        private void btnRoute_Click(object sender, EventArgs e)
        {
            this.pnlRed.Height = this.btnRoute.Height;
            this.pnlRed.Top = this.btnRoute.Top;

            controlRoute route = new controlRoute();
            MainControl.showControl(route, frmAdminDashboard.ActiveForm);
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
