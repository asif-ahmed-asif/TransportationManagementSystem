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
        public controlUser()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
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
                        this.PopulateGridView();

                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show("Cann't update user\n" + error.Message);
                }
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
                        this.PopulateGridView();
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

        private void PopulateGridView()
        {
            try
            {
                this.dgvUser.AutoGenerateColumns = false;
                this.dgvUser.DataSource = UserRepo.ShowAll();
                this.dgvUser.ClearSelection();
                this.dgvUser.Refresh();
                this.cmbStatus.SelectedIndex = 0;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error!" + e.Message);
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

            this.PopulateGridView();

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
                if (!this.cmbType.Enabled)
                {
                    this.cmbType.Enabled = true;
                    this.cmbStatus.Enabled = true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error!" + e.Message);
            }

        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearUserInput();
            this.PopulateGridView();
        }

        private void dgvUser_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.dgvUser.ClearSelection();
        }

        private void dgvUser_DoubleClick(object sender, EventArgs e)
        {
            this.rtxtId.Text = this.dgvUser.CurrentRow.Cells["user_id"].Value.ToString();
            this.rtxtName.Text = this.dgvUser.CurrentRow.Cells["name"].Value.ToString();
            this.rtxtMail.Text = this.dgvUser.CurrentRow.Cells["email"].Value.ToString();
            this.rtxtPhn.Text = this.dgvUser.CurrentRow.Cells["phone"].Value.ToString();
            this.rtxtAddress.Text = this.dgvUser.CurrentRow.Cells["address"].Value.ToString();
            this.cmbType.Text = this.dgvUser.CurrentRow.Cells["user_type"].Value.ToString();
            this.rtxtSalary.Text = this.dgvUser.CurrentRow.Cells["salary"].Value.ToString();
            this.cmbStatus.Text = this.dgvUser.CurrentRow.Cells["status"].Value.ToString();
            this.rtxtPassword.Text = this.dgvUser.CurrentRow.Cells["password"].Value.ToString();

            if (this.cmbType.Text == "Admin")
            {
                this.cmbType.Enabled = false;
                this.cmbStatus.Enabled = false;
            }
            else
            {
                this.cmbType.Enabled = true;
                this.cmbStatus.Enabled = true;
            }


        }

        private void rtxtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.dgvUser.AutoGenerateColumns = false;
                this.dgvUser.DataSource = UserRepo.SearchUser(this.rtxtSearch.Text);
                this.dgvUser.ClearSelection();
                this.dgvUser.Refresh();
            }
            catch (Exception a)
            {
                MessageBox.Show("Error!" + a.Message);
            }
        }
    }
}
