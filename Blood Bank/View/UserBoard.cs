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
    public partial class UserBoard : UserControl
    {
        public string email { get; set; }
        public UserBoard()
        {
            InitializeComponent();
        }

        private void UserBoard_Load(object sender, EventArgs e)
        {
            if(!DesignMode)
                userDtaView.DataSource = Overall.Main.ReadData<string>("readUsers");
        }

        private void userDtaView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            email = userDtaView.SelectedRows[0].Cells["Email"].Value.ToString();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (email == null)
                MessageBox.Show("Select Row to delete");
            else
            {
                Overall.Main.Delete<string>(email, "deleteUser", "@email");
                MessageBox.Show("Successfully Deleted the user");
                userDtaView.DataSource = Overall.Main.ReadData<string>("readUsers");
            }
        }
    }
}
