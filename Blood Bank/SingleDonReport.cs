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

namespace Blood_Bank
{
    public partial class SingleDonReport : Form
    {
        public SingleDonReport()
        {
            InitializeComponent();
        }

        private void SingleDonReport_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            donorReport();
        }

        private void donorReport()
        {
            int phone = 61545251;
            this.reportViewer1.LocalReport.DataSources.Clear();
            var data = Overall.Main.ReadDonor("ReadDonor", phone);
            var reportResource = new ReportDataSource("SingleDonor", data);
            reportViewer1.LocalReport.ReportPath = "SingleDonerReport.rdlc";
            reportViewer1.LocalReport.DataSources.Add(reportResource);
            reportViewer1.RefreshReport();
        }
    }
}
