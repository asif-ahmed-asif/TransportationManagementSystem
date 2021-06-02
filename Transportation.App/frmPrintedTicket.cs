
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
        public frmPrintedTicket()
        {
            InitializeComponent();
        }

        private void frmPrintedTicket_Load(object sender, EventArgs e)
        {

            ReportDataSource ds = new ReportDataSource("DataSet2", TicketRepo.printTicket());
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(ds);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
