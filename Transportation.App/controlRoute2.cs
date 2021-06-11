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

    }
}
