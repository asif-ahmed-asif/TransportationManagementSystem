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
    public partial class userControl : UserControl
    {
        private User user = new User();
        public userControl()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            user.Name = this.rtxtName.Text;
            user.Phone = this.rtxtPhn.Text;
            user.Email = this.rtxtMail.Text;
            user.Address = this.rtxtAddress.Text;
            user.Salary = this.rtxtSalary.Text;
            user.Status = this.cmbStatus.Text;
            user.UserType = this.cmbType.Text;

            try
            {
                if(UserRepo.InsertUsser(user)==1)
                    MessageBox.Show("Insertion Succesful");
            }
            catch (Exception error)
            {
                MessageBox.Show($"Error fetching data\n{error.Message}");
            }
        }

        private void userControl_Load(object sender, EventArgs e)
        {
            this.cmbStatus.Items.Add("Active");
            this.cmbStatus.Items.Add("Inactive");
            this.cmbStatus.Items.Add("Locked");

            this.cmbType.Items.Add("Admin");
            this.cmbType.Items.Add("Cashier");
            this.cmbType.Items.Add("Accountant");

            try
            {
                this.rtxtId.Text = UserRepo.GetId();
            }

            catch (Exception error)
            {
                MessageBox.Show($"Error fetching data\n{error.Message}");
            }

        }

        private void rtxtId_TextChanged(object sender, EventArgs e)
        {

        }
<<<<<<< Updated upstream
=======

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearUserInput();
        }

        private void rtxtAddress_TextChanged(object sender, EventArgs e)
        {

        }
>>>>>>> Stashed changes
    }
}
