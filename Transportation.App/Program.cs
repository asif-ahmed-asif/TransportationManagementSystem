using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transportation.App
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //aaaa
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< Updated upstream
            Application.Run(new frmDashboard());
=======
            //Application.Run(new frmLogin());
            // Application.Run(new frmDashboard());
            Application.Run(new frmCashierDashboard());
>>>>>>> Stashed changes
        }
    }
}
