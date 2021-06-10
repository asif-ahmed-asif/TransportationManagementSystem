
using Microsoft.Reporting.WinForms;
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
    public partial class frmPrintedTicket : Form
    {
        public string Phone { get; set; }
        public frmPrintedTicket()
        {
            InitializeComponent();
        }

        private void frmPrintedTicket_Load(object sender, EventArgs e)
        {
            try
            {

                ReportDataSource ds = new ReportDataSource("DataSet1", TicketRepo.printTicket(this.Phone));
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(ds);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception error)
            {
                MessageBox.Show($"Error fetching data\n{error.Message}");
            }

            
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
