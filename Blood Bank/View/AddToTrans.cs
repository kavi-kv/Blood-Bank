﻿using Blood_Bank.Controller;
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
    public partial class AddToTrans : Form
    {
        public int bId { get; set; }
        public double quantity { get; set; }
        public string bloodGroup { get; set; }
        public string type = "Donation";
        public AddToTrans(int bId, double quantity, string bloodGroup)
        {
            InitializeComponent();
            this.bId = bId;
            this.quantity = quantity;
            this.bloodGroup = bloodGroup;
        }

        private void txtBloodGroup_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddToTrans_Load(object sender, EventArgs e)
        {
            lblId.Text = "blood Bank id: "+bId.ToString();
            txtQuantity.Text = quantity.ToString();
            txtBloodGroup.Text = bloodGroup;
        }

        private void connfirmBtn_Click(object sender, EventArgs e)
        {
            if (txtHospital.Text == "" || txtBloodGroup.Text == "")
            {
                MessageBox.Show("Fill all the blank fields");
            }
            else
            {
                var trn = new Trans(bId, quantity, bloodGroup, type, txtHospital.Text, txtBloodGroup.Text);
                trn.addToTr();
                if (trn.QueryHasError)
                    Overall.Messages.ShowMessage(trn.ErrorMessage, "Error", "error");
                else
                {
                    MessageBox.Show($"Succesfully transfared {quantity} to {txtHospital.Text}");
                }
            }
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

 }

