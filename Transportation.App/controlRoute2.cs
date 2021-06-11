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
    public partial class controlRoute2 : UserControl
    {
        public controlRoute2()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            controlRoute route = new controlRoute();
            MainControl.showControl(route, frmAdminDashboard.ActiveForm);
        }

        private void controlRoute2_Load(object sender, EventArgs e)
        {
            this.FillDropDownFromDb();
        }


        private void FillDropDownFromDb() //Used to Fill the Drop Down List with bus_no
        {
            try
            {
                string[] buses = BusRepo.GetUnassignedBuses();
                


                foreach (string s in buses)
                {
                    this.cmbBusNo.Items.Add(s);
                    
                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong in drop down!" + e);
            }
        }

        private void cmbBusNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string[,] info = RouteRepo.GetRouteAndSchedule(this.cmbBusNo.Text);
                //departure location info[][0]
                //destination info[][1]
                //departure time info[2]
                //arrival info[3]

                this.txtFrom.Text = info[0, 0];
                this.txtDestination.Text = info[0, 1];
                this.txtDeptTime.Text = info[0, 2];
                this.txtArrivalTime.Text = info[0, 3];
                this.txtReturnFrom.Text = this.txtDestination.Text;
                this.txtReturnDestination.Text = this.txtFrom.Text;
            }

            catch (Exception f)
            {
                Console.WriteLine("Something went wrong when fetching data" + e);
            }
        }
    }
}
