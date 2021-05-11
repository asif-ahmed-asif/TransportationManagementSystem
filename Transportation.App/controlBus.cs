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
    public partial class controlBus : UserControl
    {
        public controlBus()
        {
            InitializeComponent();
        }

        private void controlBus_Load(object sender, EventArgs e)
        {
            this.cmbType.Items.Add("AC");
            this.cmbType.Items.Add("Non AC");
        }
    }
}
