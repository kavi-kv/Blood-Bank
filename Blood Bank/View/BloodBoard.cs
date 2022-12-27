using Blood_Bank.Controller;
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

namespace Blood_Bank.View
{
    public partial class BloodBoard : UserControl
    {
        public static Guna.UI2.WinForms.Guna2DataGridView viewDta { get; set; } = new Guna.UI2.WinForms.Guna2DataGridView();
        private string bloodGroup { get; set; }
        private int bloodId { get; set; }
        private double quantity { get; set; }
        public BloodBoard()
        {
            InitializeComponent();
            viewDta = bloodDtaView;
        }

        private void BloodBoard_Load(object sender, EventArgs e)
        {
            bloodDtaView.DataSource = Overall.Main.ReadData<string>("readFromBlood");
        }

        private void bloodDtaView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bloodId = (int)bloodDtaView.SelectedRows[0].Cells["bloodId"].Value;
            quantity = (double)bloodDtaView.SelectedRows[0].Cells["quantity"].Value;
            bloodGroup = bloodDtaView.SelectedRows[0].Cells["bloodType"].Value.ToString();
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if(bloodDtaView.SelectedRows.Count > 0)
            {
                var blood = new Blood(bloodId,quantity,bloodGroup);
                blood.AddtoBBank();
                if (blood.QueryHasError)
                    Messages.ShowMessage(blood.ErrorMessage, "Error", "error");
                else 
                {
                    MessageBox.Show("Successfully Confirmed");
                    bloodDtaView.DataSource = Main.ReadData<string>("readFromBlood");
                }
            }
        }
    }

    }

