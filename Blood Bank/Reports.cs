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

namespace Blood_Bank.View
{
    public partial class Reports : UserControl
    {
        public static int phoneNum { get; set; }
        public static int transacionId { get; set; }
        public Reports()
        {
            InitializeComponent();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
            
        }
        private void ReportAllDonors()
        {
            this.reportViewer1.LocalReport.DataSources.Clear();
            var data = Overall.Main.ReadData<string>("readDonor");
            var reportSource = new ReportDataSource("allDonors", data);
            reportViewer1.LocalReport.ReportPath = "Report1.rdlc";
            reportViewer1.LocalReport.DataSources.Add(reportSource);
            reportViewer1.RefreshReport();
        }
        private void donorReport()
        {
            phoneNum = Convert.ToInt32(txtSearchBar.Text.ToString());
            this.reportViewer1.LocalReport.DataSources.Clear();
            var data = Overall.Main.ReadDonor("ReadDonor", phoneNum);
            var reportResource = new ReportDataSource("SingleDonor", data);
            reportViewer1.LocalReport.ReportPath = "SingleDonerReport.rdlc";
            reportViewer1.LocalReport.DataSources.Add(reportResource);
            reportViewer1.RefreshReport();
        }

        private void checkBxAll_Click(object sender, EventArgs e)
        {
            checkBxSingleDon.Checked = false;
        }

        private void checkBxSingleDon_Click(object sender, EventArgs e)
        {
            txtSearchBar.Visible = true;
            checkBxAll.Checked = false;
            
        }

        private void createDocBtn_Click(object sender, EventArgs e)
        {
            
            if (checkBxSingleDon.Checked)
            {
                if (txtSearchBar.Text == "")
                    MessageBox.Show("Enter Donor's phone number in the search bar");
                else
                {
                    phoneNum = Convert.ToInt32(txtSearchBar.Text.ToString());
                    if (!Overall.Main.isNumberValid(phoneNum))
                    {
                        MessageBox.Show("Invalid Phone Number, plz check!");
                        return;
                    }
                    else
                    {
                        donorReport();
                    }
                }
            }
            if (checkBxAll.Checked)
                ReportAllDonors();

        }

        private void Reports_Load(object sender, EventArgs e)
        {
            
        }

        private void checkBxTrans_Click(object sender, EventArgs e)
        {
            checkBxSingleTrans.Checked = false;
            txtSearchBarTrans.Visible = false;
        }

        private void checkBxSingleTrans_Click(object sender, EventArgs e)
        {
            checkBxTrans.Checked = false;
            txtSearchBarTrans.Visible = true;
        }

        private void TransactionReport()
        {
            reportViewer2.LocalReport.DataSources.Clear();
            var data = Overall.Main.ReadData<string>("readTrans");
            var reportSource = new ReportDataSource("transAll", data);
            reportViewer2.LocalReport.ReportPath = ("TransAllReport.rdlc");
            reportViewer2.LocalReport.DataSources.Add(reportSource);
            reportViewer2.RefreshReport();
        }
        private void SingleReportTransaction()
        {
            int trId = Convert.ToInt32(txtSearchBarTrans.Text);
            reportViewer2.LocalReport.DataSources.Clear();
            var data = Overall.Main.ReadTrans("readSingleTrans",trId);
            var reportSource = new ReportDataSource("singleTransReport", data);
            reportViewer2.LocalReport.ReportPath = ("SingleTransReport.rdlc");
            reportViewer2.LocalReport.DataSources.Add(reportSource);
            reportViewer2.RefreshReport();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            if(checkBxTrans.Checked)
                TransactionReport();

            if (checkBxSingleTrans.Checked)
            {
                if (txtSearchBarTrans.Text == "")
                {
                    MessageBox.Show("Enter transaction's trId in the search bar");
                }
                else
                {
                    transacionId = Convert.ToInt32(txtSearchBarTrans.Text.ToString());
                    if (!Overall.Main.isTrIdValid(transacionId))
                    {
                        MessageBox.Show("Invalid Transaction Id");
                    }
                    else
                    {
                        SingleReportTransaction();
                    }
                }
            }
        }
    }
}
