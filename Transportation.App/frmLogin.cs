using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transportation.Repository;

namespace Transportation.App
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string[] loginDetails = LoginRepo.VerifyLogin(this.txtUserName.Text, this.txtPassword.Text);
                if(loginDetails.Length > 0)
                {
                    if(loginDetails[1] == "Active")
                    {
                        this.Visible = false;
                        if (loginDetails[0] == "Admin")
                        {
                            new frmAdminDashboard().Show();
                        }
                        else if (loginDetails[0] == "Cashier")
                        {
                            MainControl.cashierId = this.txtUserName.Text;
                            new frmCashierDashboard().Show();
                        }
                        else if (loginDetails[0] == "Accountant")
                        {
                            new frmAccountDashboard().Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Your account is not activated \nPlease contact to Admin", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch
            {
                MessageBox.Show("Invalid Username or Password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
