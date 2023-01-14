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
    
    public partial class DonorBoard : UserControl
    {
        public string dName { get; set; }
        public int dNum { get; set; }
        public string status { get; set; } 


        public string existedDonorName { get; set; }
        public string existedDonorBlood { get; set; }
        public string existedDonorAddress { get; set; }
        public string existedDonorSex { get; set; }
        public DonorBoard()
        {
            InitializeComponent();
            status = "Pending";
            phoneNumTxt.KeyPress += phoneNumTxt_KeyPress;
            phoneNumTxt.TextChanged += phoneNumTxt_TextChanged;
        }
        void clearTxt()
        {
            firstNameTxt.Clear();
            lastNameTxt.Clear();
            addressTxt.Clear();
            ageTxt.Clear();
            quantityTxt.Clear();
            genderCombo.SelectedIndex= -1;
            bloodGroupCombo.SelectedIndex= -1;
            phoneNumTxt.Clear();
        }
        
        
        private void DonorBoard_Load(object sender, EventArgs e)
        {
            //viewDnrDta.ColumnCount = 8;
            //viewDnrDta.Columns[0].Name = "Name";
            //viewDnrDta.Columns[1].Name = "Blood Group";
            //viewDnrDta.Columns[2].Name = "Phone";
            //viewDnrDta.Columns[3].Name = "Address";
            //viewDnrDta.Columns[4].Name = "Gender";
            //viewDnrDta.Columns[5].Name = "Date Of Donation";
            //viewDnrDta.Columns[6].Name = "Quantity";
            //viewDnrDta.Columns[7].Name = "Age";
            //dNum = Convert.ToInt32(viewDnrDta.SelectedRows[0].Cells[3].Value);
            //dName =  viewDnrDta.SelectedRows[0].Cells[1].Value.ToString();
            //searchDonorTxt.Visible = false;
            if (!this.DesignMode)
                viewDnrDta.DataSource = Overall.Main.ReadData<string>("readDonor");
            //viewDnrDta.Visible = true;
            searchDonorTxt.Visible = false;
        }

        private void DonorCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DonorCombo.SelectedIndex == 0)
            {
                regDonorPnl.Visible = true;
                viewDnrDta.Visible = false;
                searchDonorTxt.Visible = false;
            }
            else if (DonorCombo.SelectedIndex == 1)
            {
                regDonorPnl.Visible = false;
                viewDnrDta.Visible = true;
                searchDonorTxt.Visible = true;
            }

        }

        private void saveDonorBtn_Click(object sender, EventArgs e)
        {
            DateTime dataTime = DateTime.Now;
            string fullName = firstNameTxt.Text + " " + lastNameTxt.Text;
            //int age = Convert.ToInt16(ageTxt.Text);

            if (InputValidations.isDonorValid(firstNameTxt.Text, lastNameTxt.Text, bloodGroupCombo.Text, addressTxt.Text, genderCombo.Text, dataTime))
            {
                MessageBox.Show("Fill all the required fields");
            }
            else
            {
                if (!InputValidations.phoneAgeVal(phoneNumTxt.Text, ageTxt.Text))
                {
                    MessageBox.Show("Invalid format of phone number or age");
                }
                else
                {
                    if (!InputValidations.isQuantityValid(quantityTxt.Text))
                    {
                        MessageBox.Show("Invalid Quantity");
                    }
                    else
                    {


                        if (!InputValidations.isNumValid(phoneNumTxt.Text))
                        {
                            MessageBox.Show("Phone Number is too short");
                        }
                        else
                        {
                            if (!InputValidations.isValueDigit(firstNameTxt.Text, lastNameTxt.Text, addressTxt.Text))
                            {
                                MessageBox.Show("Invalid Character Input");
                            }
                            else
                            {
                                Int64 phoneNum = Convert.ToInt64(phoneNumTxt.Text);
                                var donor = new Donor(fullName, bloodGroupCombo.Text, phoneNum, addressTxt.Text, genderCombo.Text, dataTime, Convert.ToInt32(quantityTxt.Text), Convert.ToInt16(ageTxt.Text));
                                donor.RegisterDonor();
                                if (donor.QueryHasError)
                                    Messages.ShowMessage(donor.ErrorMessage, "Error", "error");
                                else
                                {
                                    MessageBox.Show($"Successfully registered a donor with name of {fullName}");
                                    viewDnrDta.DataSource = Overall.Main.ReadData<string>("readDonor");
                                    BloodBoard.viewDta.DataSource = Overall.Main.ReadData<string>("readFromBlood");
                                    clearTxt();
                                }
                            }
                        }
                    }
                }

            }
        }

        private void phoneNumTxt_TextChanged(object sender, EventArgs e)
        {

            Int64 value;
            phoneNumTxt.MaxLength = 9;
            if(!Int64.TryParse(phoneNumTxt.Text, out value)) 
            {
                phoneNumTxt.Clear();
            }
        }

        private void phoneNumTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void ageTxt_TextChanged(object sender, EventArgs e)
        {
            int value;
            ageTxt.MaxLength = 2;
            if (!int.TryParse(ageTxt.Text,out value))
            {
                ageTxt.Clear();
            }

        }

        private void ageTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void quantityTxt_TextChanged(object sender, EventArgs e)
        {
            int _value;
            //quantityTxt.MaxLength = 3;
            quantityTxt.MaxLength = 5;
            if (!int.TryParse(quantityTxt.Text, out _value))
            {
                quantityTxt.Clear();
            }
        }

        private void quantityTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

    }
 }

