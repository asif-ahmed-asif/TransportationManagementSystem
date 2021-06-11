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
    public partial class controlRoute2 : UserControl
    {
        public controlRoute2()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            controlRoute route = new controlRoute();
            MainControl.showControl(route, frmAdminDashboard.ActiveForm);
        }
    }
}
