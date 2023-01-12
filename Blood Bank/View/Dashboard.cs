using Blood_Bank.Overall;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Blood_Bank.View
{
    public partial class DashBoard : UserControl
    {
       
        public DashBoard()
        {
            InitializeComponent();
        }
        private void displaySummary()
        {
            ttBlDonation.Text = Main.readSummary("totalBloodDonations").ToString();
            ttUsers.Text = Main.readSummary("allUsers").ToString();
            ttStaff.Text = Main.readSummary("totalStaff").ToString();
            //ttPendingBlood.Text = Main.readSummary("pendinBlood").ToString();
            ttDonors.Text = Main.readSummary("totalDonors").ToString();
            maleDonorLbl.Text = Main.readSummary("MaleDonors").ToString();
            femaleDonorlbl.Text = Main.readSummary("femaleDonors").ToString();
            ttDonHosp.Text = Main.readSummary("totalDonHosp").ToString();
            ttBloodrans.Text = Main.GetTotal("Transactions", "quantity").ToString();
            ttBloodLeft.Text = Main.GetTotal("BloodBank","quantity").ToString();
            onDemandBlGlb.Text = Overall.Main.OndemandBlGroup().ToString();
        }
        private void z_Load(object sender, EventArgs e)
        {
            if(!DesignMode)
                displaySummary();
        }

        private void ttBlDonation_Click(object sender, EventArgs e)
        {
            
        }

    }
}
