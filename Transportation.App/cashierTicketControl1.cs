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
    public partial class cashierTicketControl1 : UserControl
    {
        private List<Route> RouteList;
        public cashierTicketControl1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cashierTicketControl2 second = new cashierTicketControl2();
            MainControl.showControl(second, frmCashierDashboard.ActiveForm);
           
        }

        private void cashierTicketControl1_Load(object sender, EventArgs e)
        {
            try
            {
                this.RouteList = RouteRepo.GetAll();
                foreach (var route in this.RouteList)
                {
                    this.cboFrom.Items.Add(route.DeptLocation);
                    this.cboTo.Items.Add(route.Destination);
                }
                    
            }
            catch (Exception error)
            {
                MessageBox.Show($"Error fetching data\n{error.Message}");
            }

        }
    }
}
