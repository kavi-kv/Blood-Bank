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
    public partial class AllDonorReport : Form
    {
        public AllDonorReport()
        {
            InitializeComponent();
        }

        private void AllDonorReport_Load(object sender, EventArgs e)
        {
            this.donorsReport1.RefreshReport();
            report();
        }
        private void report()
        {
            this.donorsReport1.LocalReport.DataSources.Clear();
            var data = Overall.Main.ReadData<string>("readDonor");
            var reportSource = new ReportDataSource("allDonors", data);
            donorsReport1.LocalReport.ReportPath = "Report1.rdlc";
            donorsReport1.LocalReport.DataSources.Add(reportSource);
            donorsReport1.RefreshReport();
        }
    }
}
