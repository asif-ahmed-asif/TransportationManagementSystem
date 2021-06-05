using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transportation.App
{
    class MainControl
    {
        public static string cashierFrom = "";
        public static string cashierTo = "";
        public static string cashierBusType = "";
        public static string cashierJourneyDate = "";
        public static void showControl(Control control,Form frm )
        {
            
           

            Panel panel=new Panel();
            //loop through all the controls until the desired panel is found
            foreach (Control c in frm.Controls)
            {
                if (c.GetType() == typeof(Panel))
                {

                    if (c.Name == "pnlControl")
                        panel = (Panel)c;
                }
            }


            panel.Controls.Clear();
            //Controls.Clear();

            panel.Controls.Add(control);
            control.Location = new Point()
            {
                X = panel.Width / 2 - control.Width / 2,
                Y = (panel.Height / 2 - control.Height / 2)+100
            };

            /* control.Dock = DockStyle.Fill;
             control.BringToFront();
             control.Focus();

             Controls.Add(control);*/
        }
    }
}
