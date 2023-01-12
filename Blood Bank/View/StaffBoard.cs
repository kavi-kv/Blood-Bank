using Blood_Bank.Controller;
using Blood_Bank.Overall;
using Guna.UI2.WinForms;
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
    
    public partial class StaffBoard : UserControl
    {
        bool isDelete;
        bool isUpdate;
        bool isUpdateClicked = false;
        private string name { get; set; }
        private string address { get; set; }
        private string role { get; set; }
        private string gender { get; set; }
        private Int64 phoneNum { get; set; }
        private int age { get; set; }
        private int salary { get; set; }
        private int idUpdater { get; set; }
        public StaffBoard()
        {
            InitializeComponent();
        }
        

        private void staffCmBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(staffCmBx.SelectedIndex == 1) 
            {
                staffBoardDtaView.Visible = false;
                addStaffPnl.Visible = true;
                updateAndDelBtn.Visible = false;
                txtSearch.Visible = false;
                updateDelOptionCmBx.Visible = false;
                txtLName.Visible = true;
                InputValidations.clearTxtBoxes(txtFName, txtLName, txtAddress, txtStaffRole, txtAge, txtPhoneNum, txtStaffRole, txtSalary);
                InputValidations.clearCmBox(cmbGender);
            }
            else if(staffCmBx.SelectedIndex == 0)
            {
                addStaffPnl.Visible = false;
                staffBoardDtaView.Visible = true;
                //updateAndDelBtn.Visible = true;
                txtSearch.Visible = true;
                updateDelOptionCmBx.Visible = true;
            }
            else
            {
                addStaffPnl.Visible = false;
                staffBoardDtaView.Visible = false;
            }
        }

        private void StaffBoard_Load(object sender, EventArgs e)
        {
            updateAndDelBtn.Enabled = true;
            staffCmBx.SelectedIndex = 0;
            if (!this.DesignMode)
                staffBoardDtaView.DataSource = Overall.Main.ReadData<string>("readStaff");

            updateAndDelBtn.Visible = false;
            txtSearch.Visible = false;
            updateDelOptionCmBx.Visible = true;

            

        }

        private void staffSvebtn_Click(object sender, EventArgs e)
        {
            Int64 num = 0;
            int ageTxt = 0;
            int salary = 0;
            int.TryParse(txtAge.Text, out ageTxt);
            Int64.TryParse(txtPhoneNum.Text, out num);
            int.TryParse(txtSalary.Text, out salary);
            if (isUpdate && isUpdateClicked && idUpdater > 0)
            {
                if (!InputValidations.isGenderCmBxSelected(cmbGender))
                    MessageBox.Show("Choose staff's gender pronoun");
                else
                {
                    if (!InputValidations.isPhoneValid(num, ageTxt))
                    {
                        MessageBox.Show("Phone Number Must be not less than 9 and more than 10 or age must be valid");
                    }
                    else
                    {
                        if (!InputValidations.isSalaryValid(salary))
                        {
                            MessageBox.Show("Invalid Salary input");
                        }
                        else
                        {
                            if (!InputValidations.isValueDigit(txtFName.Text, txtAddress.Text, txtPhoneNum.Text, txtAge.Text, txtSalary.Text, txtStaffRole.Text))
                            {
                                MessageBox.Show("Values must be not be digit");
                            }
                            else
                            {
                                
                                var addStaff = new Staff(txtFName.Text, txtAddress.Text, cmbGender.Text , num, txtStaffRole.Text, ageTxt, salary,idUpdater);
                                addStaff.updateStaff();
                                if (addStaff.QueryHasError)
                                    Overall.Messages.ShowMessage(addStaff.ErrorMessage, "Error", "error");
                                else
                                {
                                    MessageBox.Show("Successfull updated staff information");
                                    staffBoardDtaView.DataSource = Overall.Main.ReadData<string>("readStaff");
                                    InputValidations.clearTxtBoxes(txtFName, txtLName, txtAddress, txtStaffRole, txtAge, txtPhoneNum, txtStaffRole, txtSalary);
                                    InputValidations.clearCmBox(cmbGender);
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                if (InputValidations.isStaffInfoValid(txtFName.Text, txtLName.Text, txtAddress.Text, txtPhoneNum.Text, txtAge.Text, txtSalary.Text, txtStaffRole.Text))
                {
                    MessageBox.Show("Fill all the required blank spaces");
                }
                else
                {
                    if (!InputValidations.isGenderCmBxSelected(cmbGender))
                        MessageBox.Show("Choose staff's gender pronoun");
                    else
                    {
                        if (!InputValidations.isPhoneValid(num, ageTxt))
                        {
                            MessageBox.Show("Phone Number Must be not less than 9 and more than 10 or age must be valid");
                        }
                        else
                        {
                            if (!InputValidations.isSalaryValid(salary))
                            {
                                MessageBox.Show("Invalid Salary input");
                            }
                            else
                            {
                                if (!InputValidations.isValueDigit(txtFName.Text, txtLName.Text, txtAddress.Text, txtPhoneNum.Text, txtAge.Text, txtSalary.Text, txtStaffRole.Text))
                                {
                                    MessageBox.Show("Values must be not be digit");
                                }
                                else
                                {
                                    string fullName = txtFName.Text + " " + txtLName.Text;
                                    var addStaff = new Staff(fullName, txtAddress.Text, num, txtStaffRole.Text, ageTxt, salary, cmbGender.Text);
                                    addStaff.addStaff();
                                    if (addStaff.QueryHasError)
                                        Overall.Messages.ShowMessage(addStaff.ErrorMessage, "Error", "error");
                                    else
                                    {
                                        MessageBox.Show("Successfull registered a new staff");
                                        staffBoardDtaView.DataSource = Overall.Main.ReadData<string>("readStaff");
                                        InputValidations.clearTxtBoxes(txtFName, txtLName, txtAddress, txtStaffRole, txtAge, txtPhoneNum, txtStaffRole, txtSalary);
                                        InputValidations.clearCmBox(cmbGender);
                                    }
                                }
                            }
                        }
                    }

                }
            }
        }

        private void updateDelOptionCmBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (updateDelOptionCmBx.SelectedIndex == 0)
            {
                updateAndDelBtn.Enabled = false;
                updateAndDelBtn.Text = "";
                isDelete = false;
                isUpdate = false;
                phoneNum = 0;
                idUpdater = 0;
                
            }
            else if (updateDelOptionCmBx.SelectedIndex == 1)
            {
                phoneNum = 0;
                idUpdater = 0;
                updateOption();
            }
            else if(updateDelOptionCmBx.SelectedIndex == 2)
            {
                phoneNum = 0;
                idUpdater = 0;
                deleteOption();
            }
        }
        private void txtPhoneNum_TextChanged(object sender, EventArgs e)
        {
            Int64 _value;
            txtPhoneNum.MaxLength = 10;
            if (!Int64.TryParse(txtPhoneNum.Text, out _value))
            {
                txtPhoneNum.Clear();
            }
        }

        private void txtPhoneNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtSalary_TextChanged(object sender, EventArgs e)
        {
            Int64 _value;
            txtSalary.MaxLength = 3;
            if (!Int64.TryParse(txtSalary.Text, out _value))
            {
                txtPhoneNum.Clear();
            }
        }       
        private void updateAndDelBtn_Click(object sender, EventArgs e)
        {
            if(isDelete && !isUpdate)
            {
                if(phoneNum == 0)
                {
                    MessageBox.Show("Select Data to delete");
                }
                else
                    goingToDelete();
                backFrmUpdate.Visible = true;
            }
            else if(isUpdate && !isDelete)
            {
                if(idUpdater == 0)
                {
                    MessageBox.Show("Select Data to delete update");
                }
                else
                    goingToUpdate();
            }
        }

        private void staffBoardDtaView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idUpdater = (int)staffBoardDtaView.SelectedRows[0].Cells["id"].Value;
            phoneNum = (Int64)staffBoardDtaView.SelectedRows[0].Cells["phone"].Value;
            age = (int)staffBoardDtaView.SelectedRows[0].Cells["age"].Value;
            salary = (int)staffBoardDtaView.SelectedRows[0].Cells["salary"].Value;
            name = staffBoardDtaView.SelectedRows[0].Cells["name"].Value.ToString();
            address = staffBoardDtaView.SelectedRows[0].Cells["address"].Value.ToString();
            role = staffBoardDtaView.SelectedRows[0].Cells["staffType"].Value.ToString();
            gender = staffBoardDtaView.SelectedRows[0].Cells["gender"].Value.ToString();
        }


        //? -> User Defined User funtcions

        void goingToUpdate()
        {
            isUpdateClicked = true;
            txtFName.Text = name;
            txtAddress.Text = address;
            txtStaffRole.Text = role;
            txtPhoneNum.Text = phoneNum.ToString();
            txtAge.Text = age.ToString();
            txtSalary.Text = salary.ToString();
            cmbGender.SelectedItem = gender;
            staffBoardDtaView.Visible = false;
            addStaffPnl.Visible = true;
            label2.Text = "Full Name";
            label5.Visible = false;
            txtLName.Visible = false;
            if (addStaffPnl.Visible)
            {
                staffCmBx.Visible = false;
                updateAndDelBtn.Visible = false;
                updateDelOptionCmBx.Visible = false;
            }
        }

        void goingToDelete()
        {
            DialogResult dialogResult = MessageBox.Show($"Do You want to delete staff with the name {name}", "Delete Staff", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            else if (dialogResult == DialogResult.Yes)
            {
                Overall.Main.Delete<string>(phoneNum.ToString(), "deleteStaff", "@phoneNum");
                staffBoardDtaView.DataSource = Overall.Main.ReadData<string>("readStaff");
            }
           
        }

        void updateOption()
        {
            phoneNum = 0;
            updateAndDelBtn.Enabled = true;
            updateAndDelBtn.Text = "Update";
            updateAndDelBtn.Visible = true;
            staffBoardDtaView.ClearSelection();
            label1.Text = "Update Staff";
            isUpdate = true;
            isDelete = false;
            updateDelOptionCmBx.Visible = true;
            updateAndDelBtn.Visible = true;
        }
        void deleteOption()
        {
            idUpdater = 0;
            staffBoardDtaView.ClearSelection();
            updateAndDelBtn.Enabled = true;
            updateAndDelBtn.Text = "Delete";
            isDelete = true;
            isUpdate = false;
            updateAndDelBtn.Visible = true;
            updateDelOptionCmBx.Visible = true;
            updateAndDelBtn.Visible = true;
        }

        private void backFrmUpdate_Click(object sender, EventArgs e)
        {
            addStaffPnl.Visible = false;
            staffBoardDtaView.Visible = true;
            updateDelOptionCmBx.Visible = true;
            updateAndDelBtn.Visible = true;
            txtSearch.Visible = true;
            staffCmBx.Visible = true;
            txtLName.Visible = true;
        }
    }
}
