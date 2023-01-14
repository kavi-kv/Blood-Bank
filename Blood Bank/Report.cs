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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {

            this.reportViewer2.RefreshReport();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.reportViewer2.LocalReport.DataSources.Clear();
            var data =  Overall.Main.ReadData<string>("reportUsers");
            var reporSource = new ReportDataSource("DataSet1",data);
            reportViewer2.LocalReport.ReportPath = "usersReport.rdlc";
            reportViewer2.LocalReport.DataSources.Add(reporSource);
            reportViewer2.RefreshReport();

        }
    }
}
