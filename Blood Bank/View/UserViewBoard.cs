using Blood_Bank.Controller;
using Blood_Bank.Overall;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Blood_Bank.View
{
   
    public partial class UserViewBoard : Form
    {
        public  string fullName { get; set; }
        public  string email { get; set; }
        public  string useraName { get; set; }
        private int idUpdater { get; set; }
        public UserViewBoard()
        {
            InitializeComponent();
        }

        private void UserViewBoard_Load(object sender, EventArgs e)
        {
            updateBtn.Enabled = false;
            txtFullName.Text = Shared.Dash.fullName;
            txtEmail.Text = Shared.Dash.Email;
            txtUserName.Text = Shared.Dash.userName;
            txtSecQuestion.Text = Shared.Dash.secQ;
            txtSecAns.Text = Shared.Dash.secAns;
            idUpdater = Shared.Dash.userId;
            
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (InputValidations.isTextBoxEmpty(txtFullName, txtEmail, txtUserName, txtSecQuestion, txtSecAns))
                MessageBox.Show("Fill all the required fields");
            else
            {
                var users = new Users(txtFullName.Text, txtEmail.Text, txtUserName.Text, txtSecQuestion.Text, txtSecAns.Text,idUpdater);
                users.updateUserViewInfo();
                if (users.QueryHasError)
                    Overall.Messages.ShowMessage(users.ErrorMessage, "Error", "error");
                else
                {
                    DialogResult dialogResult = MessageBox.Show($"The update will take place after you restart the application do you want to restart ? ", "Update Information", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                    else
                    {
                        Application.Exit();
                        Process.Start(Application.ExecutablePath);
                        Process.Start(Application.ExecutablePath);
                    }

                }
            }
        }

        private void updateCheckBx_Click(object sender, EventArgs e)
        {
            if(updateCheckBx.Checked)
            {
                txtFullName.Enabled = true;
                txtEmail.Enabled = true;
                txtUserName.Enabled = true; 
                txtSecQuestion.Enabled = true;
                txtSecAns.Enabled = true;
                updateBtn.Enabled = true;
            }
            else
            {
                txtFullName.Enabled = false;
                txtEmail.Enabled = false;
                txtUserName.Enabled = false;
                txtSecQuestion.Enabled = false;
                txtSecQuestion.Enabled = false;
                updateBtn.Enabled= false;
            }
        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
