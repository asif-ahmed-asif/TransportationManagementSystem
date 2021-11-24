﻿using System;
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
                        this.Hide();
                        if (loginDetails[0] == "Admin")
                        {
                            new frmAdminDashboard(this).Show();
                        }
                        else if (loginDetails[0] == "Cashier")
                        {
                            MainControl.cashierId = this.txtUserName.Text;
                            new frmCashierDashboard(this).Show();
                        }
                        else if (loginDetails[0] == "Accountant")
                        {
                            new frmAccountDashboard(this).Show();
                        }
                        this.txtUserName.Text = "";
                        this.txtPassword.Text = "";
                        btnViewPassword.BackgroundImage = Properties.Resources.s1;
                        txtPassword.UseSystemPasswordChar = true;
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

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void btnViewPassword_Click(object sender, EventArgs e)
        {

            if (txtPassword.UseSystemPasswordChar)
            {
                btnViewPassword.BackgroundImage = Properties.Resources.p1;
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                btnViewPassword.BackgroundImage = Properties.Resources.s1;
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
