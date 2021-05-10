using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transportation.Entity;
using Transportation.Repository;

namespace Transportation.App
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(String.Empty))
            {
                MessageBox.Show("User Name Required!");
            }
            else if (textBox2.Text.Equals(String.Empty))
            {
                MessageBox.Show("Password Required!");
            }
            else
            {
                Login login = new Login();

                login.Password = textBox1.Text;
                login.UserId = textBox2.Text;
                int row = LoginRepo.CheckUserForLogin(login);
                if (row == 1)
                {
                    using (frmDashboard das = new frmDashboard())
                    {
                        das.ShowDialog();

                    }
                }
                else
                {
                    MessageBox.Show("User Name did not match with the Password! Try Again");
                }
            }

        }


        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
