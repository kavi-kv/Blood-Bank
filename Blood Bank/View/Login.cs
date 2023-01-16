using Blood_Bank.Controller;
using Blood_Bank.Overall;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_Bank.View
{
    public partial class Login : Form
    {
     
        public static string userName { get; set; }
        public static string name { get; set; }
        public static string password { get; set; }
        public bool Issucced { get; private set; }
        public Login()
        {
            InitializeComponent();
            userName = name;
        }
        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void isAdminValid()
        {
            bool adminExists = Users.CheckAdminExistence();
            if (adminExists)
            {
                LgPanel.Visible = true;
                signUpPnl.Visible = false;
            }
            else
            {
                LgPanel.Visible = false;
                signUpPnl.Visible = true;
            }
        }
        private void Login_Load(object sender, EventArgs e)
        {
            isAdminValid();
           var user = RememberUser.LoadUserName();
            signInNameTxt.Text = user.name;
            signInPassTxt.Text = user.password;
            if (!string.IsNullOrWhiteSpace(user.password)) rememberCheckBx.Checked = true;
        }

        private void securityQCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string role = "Admin";
            if (InputValidations.isAdminRegValid(fNameTxt.Text, emailTxt.Text, userNameTxt.Text,passTxt.Text,securityQCombo,secutyAnswerTxt.Text))
            {
                MessageBox.Show("Invalid Credentials fill all the blank spaces");
            }
            else
            {
                var user = new Users(fNameTxt.Text,emailTxt.Text, role, userNameTxt.Text,passTxt.Text, securityQCombo.Text, secutyAnswerTxt.Text);
                user.addUserAsAdmin();
                if (user.QueryHasError)
                    Overall.Messages.ShowMessage(user.ErrorMessage, "Error", "error");
                else 
                {
                    MessageBox.Show("Successfully Registered a new admin");
                    signUpPnl.Visible = false;
                    LoginPanel.Visible = true;
                }
            }
        }
      
        private void loginBtn_Click(object sender, EventArgs e)
        {
            var dash = new Dash();
            if(InputValidations.isLogin(signInNameTxt,signInPassTxt))
            {
                MessageBox.Show("Fill all the blank fields ");
            }
            else
            {
                bool isLoginTrue = Users.LoginCredentials<string>(signInNameTxt.Text, signInPassTxt.Text);
                
                if (isLoginTrue)
                {
                    name = signInNameTxt.Text.ToString();
                    userName = name;
                    RememberUser.SaveUserName(signInNameTxt.Text, rememberCheckBx.Checked ? signInPassTxt.Text : "");
                    Issucced = true;
                    this.Close(); 
                }
                else
                {
                    MessageBox.Show("Invalid username or password");
                }
            }
            
        }

        private void label9_Click(object sender, EventArgs e)
        {
            ForgetPass fgp = new ForgetPass();
            this.Hide();
            fgp.ShowDialog();
            
        }
    }
}
