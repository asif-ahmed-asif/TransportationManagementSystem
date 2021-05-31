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
    public partial class Transportation : Form
    {
        public Transportation()
        {
            InitializeComponent();
            this.pnlRed.Height = this.btn1.Height;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.pnlRed.Height = this.btn1.Height;
            this.pnlRed.Top = this.btn1.Top;
           // AccControl1.BringToFront();

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

        private void frmDashboard_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.pnlRed.Height = this.button1.Height;
            this.pnlRed.Top = this.button1.Top;

        }
        /* private void SetPanelPosition(object button)
{
this.pnlRed.Height = button.Height;
this.pnlRed.Top = this.btnProfile.Top;
} */
    }
}
