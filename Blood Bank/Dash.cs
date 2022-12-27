using Blood_Bank.View;
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
    public partial class Dash : Form
    {
        public Dash()
        {
            InitializeComponent();
        }

        private void donorDashBtn_Click(object sender, EventArgs e)
        {
            donorBoard2.Visible = true;
            bloodBoard2.Visible = false;
            bbankBoard1.Visible = false;
            transaction1.Visible = false;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            bloodBoard2.Visible = true;
            donorBoard2.Visible = false;
            bbankBoard1.Visible = false;
            transaction1.Visible = false;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            donorBoard2.Visible = false;
            bloodBoard2.Visible = false;
            bbankBoard1.Visible = false;
            transaction1.Visible = false;
        }

        private void bloodBnkBtn_Click(object sender, EventArgs e)
        {
            bbankBoard1.Show();
            donorBoard2.Visible = false;
            bloodBoard2.Visible = false;
            transaction1.Visible = false;
        }

        private void transBtn_Click(object sender, EventArgs e)
        {
            transaction1.Show();
            donorBoard2.Visible = false;
            bloodBoard2.Visible = false;
            bbankBoard1.Visible = false;
        }
    }
}
