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
    public partial class AddUser : Form
    {
        string role = "User";
        public AddUser()
        {
            InitializeComponent();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if(InputValidations.isTextBoxEmpty(txtFullname,txtEmail,txtUsername,txtSecAnswer,txtPass))
            {
                MessageBox.Show("Field all the blank spaces");
            }
            else
            {
                if (cmbSecQ.SelectedIndex == -1)
                    MessageBox.Show("Select Sec question");
                else
                {
                    if(!InputValidations.isValueDigit(txtFullname.Text,txtUsername.Text,txtEmail.Text,txtSecAnswer.Text))
                    {
                        MessageBox.Show("Invalid Digit");
                    }
                    else
                    {
                        string secQ = txtSecAnswer.Text;
                        var user = new Users(txtFullname.Text, txtEmail.Text, role, txtUsername.Text, txtPass.Text, cmbSecQ.Text, secQ);
                        user.addUser();
                        if (user.QueryHasError)
                            Overall.Messages.ShowMessage(user.ErrorMessage, "Error", "error");
                        else
                        {
                            MessageBox.Show("Successfully Saved the user");
                            this.Close();
                        }
                    }
                }
            }
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
