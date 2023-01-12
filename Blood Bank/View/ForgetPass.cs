using Blood_Bank.Controller;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using Guna.UI2.WinForms;
using Blood_Bank.Overall;

namespace Blood_Bank.View
{
    public partial class ForgetPass : Form
    {
        public string currEmail { get; set; }
        private bool isclickkedByEmail = false;
        private bool isclickkedBySecQ = false;
       
        public ForgetPass()
        {
            InitializeComponent();
            currEmail = emailTxtBx.Text;
        }
        void ChangePass()
        {
            EmailChildPnl.Visible = false;
            label4.Visible = false;
            label2.Visible = false;
            emailTxtBx.Visible = false;
            confirmEmailBtn.Visible = false;
        }
        private void byEmailBtn_Click(object sender, EventArgs e)
        {
            isclickkedByEmail=true;
            EmailPnl.Visible = true;
        }

        private void bySecQBtn_Click(object sender, EventArgs e)
        {
            isclickkedBySecQ = true;
            EmailPnl.Visible = true;
            //SecQPnl.Visible = true;
        }


        private void confirmEmailBtn_Click(object sender, EventArgs e)
        {
            //? -> Send code into users email using SMTP

            if(isclickkedByEmail)
            {
                if (string.IsNullOrEmpty(emailTxtBx.Text))
                    MessageBox.Show("Fill the TextBox to proceed");
                else
                {
                    string email = emailTxtBx.Text;
                    bool emailExist = Users.isEmailExist(email);
                    if (emailExist)
                    {
                        EmailSender.sendEmail(emailTxtBx.Text);
                        EmailChildPnl.Visible = true;

                    }
                    else
                        MessageBox.Show("Email Doen't Exist");
                }
            }
            else if(isclickkedBySecQ)
            {
                var combaSecQ = new Main();
                combaSecQ.readSecQuestionByEmail(secQCombx, emailTxtBx.Text);
                if (string.IsNullOrEmpty(emailTxtBx.Text))
                    MessageBox.Show("Fill the TextBox to proceed");
                else
                {
                    string email = emailTxtBx.Text;
                    bool emailExist = Users.isEmailExist(email);
                    if (emailExist)
                    {
                        SecQPnl.Visible = true;
                    }
                    else
                        MessageBox.Show("Email Doen't Exist");
                }
               
            }
            
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            this.Close();
            lg.Show();
           
        }

        private void EmailVerComfBtn_Click(object sender, EventArgs e)
        {
            var otpMsg = EmailSender.otpCode;
            if(txtEMailVercode.Text == otpMsg.ToString())
            {
                EmailChildPnl.Visible = false;
                changePassPnl.Visible = true;
            }
            else
            {
                MessageBox.Show("Invalid Code");
            }
        }

        private void secConfBtn_Click(object sender, EventArgs e)
        {
            bool isSeqAndSecAnsValid = Users.isSecQandSecAnsValid(emailTxtBx.Text,secQCombx.Text,secAnswerCmbBx.Text);
         
            if (secQCombx.SelectedIndex == -1 || secAnswerCmbBx.Text == "")
            {
                MessageBox.Show("Select Security Question and answer the question before you proceed");
            }
            else
            {
                if (isSeqAndSecAnsValid)
                {
                    SecQPnl.Visible = false;
                    changePassPnl.Visible = true;
                }
                else
                    MessageBox.Show("Invalid Security Question or Answer");
            }
        }

        private void passChangeBtn_Click(object sender, EventArgs e)
        {
            bool newPass = string.IsNullOrEmpty(txtNewPass.Text);
            bool newPassConfirm = string.IsNullOrEmpty(txtConfrimNwPass.Text);
            if (newPass && newPassConfirm)
            {
                MessageBox.Show("Field all the blank spaces");
            }
            else
            {
                if(txtNewPass.Text != txtConfrimNwPass.Text) 
                {
                    MessageBox.Show("Password is not matching");
                }
                else
                {
                    var user = new Users();
                    user.changePassByEmail(emailTxtBx.Text, txtNewPass.Text);
                    if (user.QueryHasError)
                        Overall.Messages.ShowMessage(user.ErrorMessage, "Error", "error");
                    else
                    {
                        MessageBox.Show("Password successfully changed");
                        this.Close();
                    }
                }
            }
        }
    }
}
