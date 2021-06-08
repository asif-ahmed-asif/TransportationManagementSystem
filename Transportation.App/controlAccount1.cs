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
    public partial class controlAccount1 : UserControl
    {
        public controlAccount1()
        {
            InitializeComponent();
        }

        private void controlAccount1_Load(object sender, EventArgs e)
        {
            this.dtpReport.MaxDate = DateTime.Now;
            MessageBox.Show(this.dtpReport.Value.ToString("yyyy/MM/dd"));
        }

        private void dtpReport_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show(this.dtpReport.Value.ToString("yyyy/MM/dd"));
        }
    }
}
