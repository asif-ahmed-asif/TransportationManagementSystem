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
<<<<<<< HEAD
<<<<<<< Updated upstream
            //Application.Run(new frmLogin());
=======
           // Application.Run(new frmLogin());
>>>>>>> Stashed changes
            Application.Run(new frmAdminDashboard());
=======
            Application.Run(new frmLogin());
            //Application.Run(new frmAdminDashboard());
>>>>>>> master
            //Application.Run(new AdminForm());
        }
    }
}
