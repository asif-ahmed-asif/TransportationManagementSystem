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
    public partial class frmSeatVIew : Form
    {
        public frmSeatVIew()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            
        }

        private void frmSeatVIew_Load(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {

                if (c.GetType() == typeof(Button))
                {

                    
                     if (c.Name != "btnConfirm")
                         c.Click+=buttonClick;
                }
            }

        }

        private void buttonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if(button.BackColor != Color.FromArgb(91, 123, 227))
            {
                button.BackColor = Color.FromArgb(91, 123, 227);
                button.ForeColor = Color.White;
            }
            else
            {
                
                button.BackColor = SystemColors.ControlLight;
                button.ForeColor = SystemColors.ControlText;
            }
        }

        
    }
}
