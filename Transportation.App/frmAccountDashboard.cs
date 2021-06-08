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

        private void btnProfile_Click(object sender, EventArgs e)
        {
            this.pnlRed.Height = this.btnRevenue.Height;
            this.pnlRed.Top = this.btnRevenue.Top;
            controlAccount2 control = new controlAccount2();
            MainControl.showControl(control, frmAccountDashboard.ActiveForm);
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

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            this.pnlRed.Height = this.btnWithdraw.Height;
            this.pnlRed.Top = this.btnWithdraw.Top;
            controlAccount3 control = new controlAccount3();
            MainControl.showControl(control, frmAccountDashboard.ActiveForm);
        }
        /* private void SetPanelPosition(object button)
{
this.pnlRed.Height = button.Height;
this.pnlRed.Top = this.btnProfile.Top;
} */
    }
}
