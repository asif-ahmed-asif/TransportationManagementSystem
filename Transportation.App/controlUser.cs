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
using Transportation.Validation;
using FluentValidation.Results;

namespace Transportation.App
{
    public partial class controlUser : UserControl
    {
        private User User { get; set; }
        private Login Login { get; set; }
        private string CurrentUserId { get; set; }
        public controlUser()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //var idExists = UserRepo.SearchUserId(this.CurrentUserId);
            var idExists = UserRepo.SearchUserId(this.rtxtId.Text);
            if (idExists)
            {

                try
                {
                    if (!this.UpdateFillEntity())
                        return;
                    if (UserRepo.Update(this.User) && LoginRepo.Update(this.Login))
                    {
                        MessageBox.Show("Successfully updated  user");
                        this.rtxtId.Text = UserRepo.GetId();
                        this.ClearUserInput();
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show("Cann't update user\n" + error.Message);
                    this.ClearUserInput();
                }
                this.CurrentUserId = null;
            }
            else
            {
                if (this.cmbType.Text == "Admin")
                {
                    MessageBox.Show("Can not create a new admin");
                    return;
                }
                try
                {
                    if (!this.FillEntity())
                        return;
                    if (UserRepo.Save(this.User) && LoginRepo.Save(this.Login))
                    {
                        MessageBox.Show("Successfully created new user");        
                        this.rtxtId.Text = UserRepo.GetId();
                        this.ClearUserInput();
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show("Cann't add user\n" + error.Message);
                }
            }

        }

        private bool FillEntity()
        {
            this.User = new User
            {
                UserId = UserRepo.GetId(),
                Name = this.rtxtName.Text,
                Email = this.rtxtMail.Text,
                Phone = this.rtxtPhn.Text,
                Address = this.rtxtAddress.Text,
                Password = this.rtxtPassword.Text,
                UserType = this.cmbType.Text,
                Salary = this.rtxtSalary.Text,
                Status = this.cmbStatus.Text
            };

            this.Login = new Login
            {
                Password = this.rtxtPassword.Text,
                UserId = this.User.UserId
            };

            UserValidation validator = new UserValidation();
            ValidationResult results = validator.Validate(this.User);
            IList<ValidationFailure> failures = results.Errors;
            if (!(results.IsValid))
            {
                foreach (ValidationFailure failure in failures)
                {
                    MessageBox.Show(failure.ErrorMessage, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return false;
                }
            }
            return true;
        }

        private bool UpdateFillEntity()
        {
            this.User = new User
            {
                //UserId = this.CurrentUserId,
                UserId = this.rtxtId.Text,
                Name = this.rtxtName.Text,
                Email = this.rtxtMail.Text,
                Phone = this.rtxtPhn.Text,
                Address = this.rtxtAddress.Text,
                Password = this.rtxtPassword.Text,
                UserType = this.cmbType.Text,
                Salary = this.rtxtSalary.Text,
                Status = this.cmbStatus.Text
            };

            this.Login = new Login
            {
                Password = this.rtxtPassword.Text,
                UserId = this.User.UserId
            };

            UserValidation validator = new UserValidation();
            ValidationResult results = validator.Validate(this.User);
            IList<ValidationFailure> failures = results.Errors;
            if (!(results.IsValid))
            {
                foreach (ValidationFailure failure in failures)
                {
                    MessageBox.Show(failure.ErrorMessage, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return false;
                }
            }
            return true;
        }

        private void userControl_Load(object sender, EventArgs e)
        {
            this.cmbStatus.Items.Add("Active");
            this.cmbStatus.Items.Add("Inactive");
            this.cmbStatus.Items.Add("Locked");

            this.cmbType.Items.Add("Admin");
            this.cmbType.Items.Add("Cashier");
            this.cmbType.Items.Add("Accountant");

            int n=0;
            for (int i = 0; i < 5; i++)
            {
                n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = "101";
                dataGridView1.Rows[n].Cells[1].Value = "101";
                dataGridView1.Rows[n].Cells[2].Value = "101";
                dataGridView1.Rows[n].Cells[3].Value = "101";
                dataGridView1.Rows[n].Cells[4].Value = "101";
                dataGridView1.Rows[n].Cells[5].Value = "101";
                dataGridView1.Rows[n].Cells[6].Value = "101";
                dataGridView1.Rows[n].Cells[7].Value = "101";
                n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = "102";
                dataGridView1.Rows[n].Cells[1].Value = "102";
                dataGridView1.Rows[n].Cells[2].Value = "102";
                dataGridView1.Rows[n].Cells[3].Value = "102";
                dataGridView1.Rows[n].Cells[4].Value = "102";
                dataGridView1.Rows[n].Cells[5].Value = "102";
                dataGridView1.Rows[n].Cells[6].Value = "102";
                dataGridView1.Rows[n].Cells[7].Value = "102";

                n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = "103";
                dataGridView1.Rows[n].Cells[1].Value = "102";
                dataGridView1.Rows[n].Cells[2].Value = "102";
                dataGridView1.Rows[n].Cells[3].Value = "102";
                dataGridView1.Rows[n].Cells[4].Value = "102";
                dataGridView1.Rows[n].Cells[5].Value = "102";
                dataGridView1.Rows[n].Cells[6].Value = "102";
                dataGridView1.Rows[n].Cells[7].Value = "102";

            }

            try
            {
                this.rtxtId.Text = UserRepo.GetId();
            }

            catch (Exception error)
            {
                MessageBox.Show($"Error fetching data\n{error.Message}");
            }

        }

        private void ClearUserInput()
        {
            try
            {
                this.rtxtId.Text = UserRepo.GetId();
                this.rtxtName.Text = "";
                this.rtxtMail.Text = "";
                this.rtxtPhn.Text = "";
                this.rtxtAddress.Text = "";
                this.rtxtPassword.Text = "";
                this.cmbType.SelectedIndex = -1;
                this.rtxtSalary.Text = "";
                this.cmbStatus.SelectedIndex = -1;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error!" + e.Message);
            }

        }

        private void rtxtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearUserInput();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
