using Blood_Bank.Overall;
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
using System.Xml.Linq;

namespace Blood_Bank
{
    public partial class Dash : Form
    {
        public static int userId { get; set; }
        public static string fullName { get; set; }
        public static string userName { get; set; }
        public static string Email { get; set; }
        public static string Address { get; set; }
        public static string secQ { get; set; }
        public static string secAns { get; set; }
        public Dash()
        {
            InitializeComponent();
            Shared.Dash = this;
            Shared.fromBloodGroup = bbankBoard1.fromBloodGroup;
        }

        private void donorDashBtn_Click(object sender, EventArgs e)
        {
            donorBoard2.Visible = true;
            bloodBoard2.Visible = false;
            bbankBoard1.Visible = false;
            transaction1.Visible = false;
            staffBoard1.Visible = false;
            dashBoard1.Visible = false;
            reports1.Visible = false;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            bloodBoard2.Visible = true;
            donorBoard2.Visible = false;
            bbankBoard1.Visible = false;
            transaction1.Visible = false;
            staffBoard1.Visible = false;
            dashBoard1.Visible = false;
            userBoard1.Visible = false;
            reports1.Visible = false;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            dashBoard1.Visible = true;
            donorBoard2.Visible = false;
            bloodBoard2.Visible = false;
            bbankBoard1.Visible = false;
            transaction1.Visible = false;
            staffBoard1.Visible = false;
            userBoard1.Visible = false;
            reports1.Visible = false;
        }
        public BbankBoard getBankRef()
        {
            return bbankBoard1;
        }
        bool didWeRead = false;
        private void bloodBnkBtn_Click(object sender, EventArgs e)
        {
            bbankBoard1.Show();
            donorBoard2.Visible = false;
            bloodBoard2.Visible = false;
            transaction1.Visible = false;
            dashBoard1.Visible = false;
            userBoard1.Visible = false;
            reports1.Visible = false;
            //if (!didWeRead)
            //{
            //    bbankBoard1.BankDtaView.DataSource = Main.ReadData<string>("readFromBbank");
            //    didWeRead = true;
            //}
            //var newData = Main.ReadData<string>("readFromBbank");
            //BbankBoard.BankDtaView.DataSource = newData;
            //BbankBoard.BankDtaView.Refresh();
        }

        private void transBtn_Click(object sender, EventArgs e)
        {
            transaction1.Show();
            donorBoard2.Visible = false;
            bloodBoard2.Visible = false;
            bbankBoard1.Visible = false;
            staffBoard1.Visible = false;
            dashBoard1.Visible = false;
            userBoard1.Visible = false;
            reports1.Visible = false;
        }

        private void staffBtn_Click(object sender, EventArgs e)
        {
            transaction1.Visible = false;
            donorBoard2.Visible = false;
            bloodBoard2.Visible = false;
            bbankBoard1.Visible = false;
            staffBoard1.Visible = true;
            dashBoard1.Visible = false;
            userBoard1.Visible = false;
            reports1.Visible = false;
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Do you want to Exit from the application", "Close Application",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                RememberUser.SaveUserName(userName);
                Application.Restart();
            }
        }

        private void userBtn_Click(object sender, EventArgs e)
        {
            transaction1.Visible = false;
            donorBoard2.Visible = false;
            bloodBoard2.Visible = false;
            bbankBoard1.Visible = false;
            staffBoard1.Visible = false;
            dashBoard1.Visible = false;
            userBoard1.Visible = true;
            reports1.Visible = false;
        }

        private void Dash_Load(object sender, EventArgs e)
        {
            var login = new Login();
            string name = Login.userName;
            Overall.Main.loggedIn(name);
            txtFullName.Text = fullName;
            if (!Main.isAdmin(userName))
                brefilage();
        }

        private void userIcon_Click(object sender, EventArgs e)
        {
            showUserView();
        }

        void showUserView()
        {
            Dash dash = new Dash();
            UserViewBoard viewBoard = new UserViewBoard();
            dash.Opacity = 0.5;
            viewBoard.ShowDialog();
           
        }
        public void brefilage()
        {
            dashBtn.Hide();
            staffBtn.Hide();
            userBtn.Hide();
            donorDashBtn.Location = new Point(0, 163);
            bloodBtn.Location = new Point(-3, 225);
            bloodBnkBtn.Location = new Point(0, 287);
            transBtn.Location = new Point(0, 349);
            dashBoard1.Visible = false;
            donorBoard2.Visible = true;
        }

        private void reportsBtn_Click(object sender, EventArgs e)
        {
            transaction1.Visible = false;
            donorBoard2.Visible = false;
            bloodBoard2.Visible = false;
            bbankBoard1.Visible = false;
            staffBoard1.Visible = false;
            dashBoard1.Visible = false;
            userBoard1.Visible = false;
            reports1.Visible = true;
        }
    }
}
