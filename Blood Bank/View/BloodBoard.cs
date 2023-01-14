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
        private Int64 phone { get; set; }
        public BloodBoard()
        {
            InitializeComponent();
            viewDta = bloodDtaView;
        }

        private void BloodBoard_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
                bloodDtaView.DataSource = Overall.Main.ReadData<string>("readFromBlood");
        }

        private void bloodDtaView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bloodId = (int)bloodDtaView.SelectedRows[0].Cells["bloodId"].Value;
            phone = (int)bloodDtaView.SelectedRows[0].Cells[2].Value;
            quantity = (double)bloodDtaView.SelectedRows[0].Cells["quantity"].Value;
            bloodGroup = bloodDtaView.SelectedRows[0].Cells["bloodType"].Value.ToString();
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if (bloodDtaView.SelectedRows.Count > 0)
            {
                //Alert al = new Alert($"Do you want to add the donation with the id {bloodId} to the Blood Bank", "Add");
                //al.ShowDialog();
                // if (al.IsYes != null && !al.IsYes.Value) return;
                DialogResult dialogResult = MessageBox.Show($"Do you want to add the donation with the id {bloodId} to the Blood Bank", "Add", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.No)
                    return;
                else
                {
                    var blood = new Blood(bloodId, quantity, bloodGroup);
                    blood.AddtoBBank();
                    if (blood.QueryHasError)
                        Messages.ShowMessage(blood.ErrorMessage, "Error", "error");
                    else
                    {
                        MessageBox.Show("Successfully Confirmed");
                        bloodDtaView.DataSource = Main.ReadData<string>("readFromBlood");
                        BbankBoard.BankDtaView.Refresh();
                        BbankBoard.BankDtaView.DataSource = Main.ReadData<string>("readFromBbank");
                        Shared.fromBloodGroup();
                    }
                }
            }

        }
        private void Delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show($"Do you want to delete the donation with the id {bloodId}","Delete",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(bloodDtaView.SelectedRows.Count > 0)
            {
                if (dialogResult == DialogResult.No)
                    return;
                else
                {
                    MessageBox.Show("Successfully Deleted the donation");
                    Main.deleteDonorBlood<Int64>(phone);
                    bloodDtaView.DataSource = Main.ReadData<string>("readFromBlood");
                }
            }
        }

        
    }

    }

