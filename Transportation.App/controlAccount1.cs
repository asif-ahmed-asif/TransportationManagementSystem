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
    public partial class controlAccount1 : UserControl
    {
        public controlAccount1()
        {
            InitializeComponent();
        }

        private void controlAccount1_Load(object sender, EventArgs e)
        {
            this.dtpReport.MaxDate = DateTime.Now;
            this.FillUserSalesDataGridView(); //When form is load, data will be shown interms of the current date in the data grid view
            //MessageBox.Show(this.dtpReport.Value.ToString("yyyy/MM/dd"));
        }

        private void FillUserSalesDataGridView()
        {
            this.dgvDate.AutoGenerateColumns = false;

            try
            {
                this.dgvDate.DataSource = SalesRepo.UserSalesByDate(DateTime.Now.ToString("yyyy/MM/dd"), DateTime.Now.ToString("yyyy/MM/dd"));
            }
            catch (Exception exception)
            {
                MessageBox.Show("Something went wrong when loading data!" + exception.Message);
            }

            this.dgvDate.ClearSelection();
            this.dgvDate.Refresh();
        }

        private void dtpReport_ValueChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(this.dtpReport.Value.ToString("yyyy/MM/dd"));

            this.dgvDate.AutoGenerateColumns = false;
            try
            {
                this.dgvDate.DataSource = SalesRepo.UserSalesByDate(this.dateTimePickerStartsFrom.Value.ToString("yyyy/MM/dd"), this.dtpReport.Value.ToString("yyyy/MM/dd"));
            }
            catch (Exception exception)
            {
                MessageBox.Show("Something went wrong!" + exception.Message);
            }
            
            this.dgvDate.ClearSelection();
            this.dgvDate.Refresh();
        }
        
        private void ControlAccountUserSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.dgvDate.DataSource = SalesRepo.LiveSearchUser(this.ControlAccountUserSearch.Text, this.dateTimePickerStartsFrom.Value.ToString("yyyy/MM/dd"), this.dtpReport.Value.ToString("yyyy/MM/dd"));
            }
            catch (Exception exception)
            {
                Console.WriteLine("Something went wrong when searching!"+ exception.Message);
            }
        }

        private void dgvDate_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.dgvDate.ClearSelection();
        }

        private void dateTimePickerStartsFrom_ValueChanged(object sender, EventArgs e)
        {
            this.dgvDate.AutoGenerateColumns = false;
            try
            {
                this.dgvDate.DataSource = SalesRepo.UserSalesByDate(this.dateTimePickerStartsFrom.Value.ToString("yyyy/MM/dd"), this.dtpReport.Value.ToString("yyyy/MM/dd"));
            }
            catch (Exception exception)
            {
                MessageBox.Show("Something went wrong!" + exception.Message);
            }
            
            this.dgvDate.ClearSelection();
            this.dgvDate.Refresh();
        }
    }
}
