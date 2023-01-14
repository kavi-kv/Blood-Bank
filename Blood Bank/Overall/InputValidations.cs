using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_Bank.Overall
{
    public class InputValidations
    {
        


        //public static bool isDonorValid(string name,string bloodGroup,int phoneNum,string address,string sex,DateTime date,double quantity,int age)
        //{
        //    return name.Equals("") || bloodGroup.Equals("") || phoneNum == 0 || address.Equals("") || sex.Equals("") || date.Equals("") || age == 0;
        //}
        public static bool isDonorValid(string firstName,string secondName, string bloodGroup, string address, string sex, DateTime date)
        {
            return string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(secondName) || string.IsNullOrEmpty(bloodGroup)  || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(sex) || date.Equals("") ;
        }
        //?: -> Checks if the phone number is valid and is not morethan 9
        public static bool isNumValid(string phone)
        {
            return phone.Length == 9 ;
        }
        //?: -> This method will check the validty of both mobile and age
        public static bool phoneAgeVal(string phone, string age)
        {
            if(string.IsNullOrEmpty(age) || string.IsNullOrEmpty(phone))
            {
                return false;
            }
            if (phone.Length < 9 && age.Length > 0 && age.Length < 2)
            {
                return false;
            }
            int ageInt = Convert.ToInt32(age);
            return  ageInt >= 18 && ageInt <= 65 ;
        }
        //?: Checks if the blood quantity is valid
        public static bool isQuantityValid(string quantity)
        {
            if (string.IsNullOrEmpty(quantity))
            {
                return false;
            }
            int qty = Convert.ToInt16(quantity);
            return qty >= 460 && qty < 501;
        }
         public static bool isAdminRegValid(string fName,string lName,string userName,string password,ComboBox secQ,string secAnswer)
        {
            return string.IsNullOrEmpty(fName) || string.IsNullOrEmpty(lName) ||
                string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(secQ.Text) || string.IsNullOrEmpty(secAnswer);
        }
        public static bool isStaffInfoValid(string fName,string lName,string address,string phone,string age,string salary,string role)
        {

            return string.IsNullOrEmpty(fName) || string.IsNullOrEmpty(lName) || string.IsNullOrEmpty(address) ||
                string.IsNullOrEmpty(role) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(age) ||
                string.IsNullOrEmpty(salary);

        }

        public static bool isValueDigit(string fName, string lName, string address, string phone, string age, string salary, string role)
        {
            if ((fName.All(char.IsDigit)) || lName.All(char.IsDigit) || address.All(char.IsDigit) || role.All(char.IsDigit))
            {
                return false;
            }

            return true;
        } 
        //?: Overload 1
        public static bool isValueDigit(string fName, string address, string phone, string age, string salary, string role)
        {
            if ((fName.All(char.IsDigit)) ||  address.All(char.IsDigit) || role.All(char.IsDigit))
            {
                return false;
            }

            return true;
        }
        //?: Overload 2
        public static bool isValueDigit(string fName, string lName, string address)
        {
            if ((fName.All(char.IsDigit)) ||  address.All(char.IsDigit) || lName.All(char.IsDigit))
            {
                return false;
            }

            return true;
        }
        //?: Overload 3
        public static bool isValueDigit(string staffName, string hospName)
        {
            if ((staffName.All(char.IsDigit)) || hospName.All(char.IsDigit))
            {
                return false;
            }

            return true;
        }

        public static bool isGenderCmBxSelected(Guna.UI2.WinForms.Guna2ComboBox gender)
        {
            if (gender.SelectedIndex == -1)
                return false;
            else
                return true;
        }
        public static bool isLogin(Guna.UI2.WinForms.Guna2TextBox userName, Guna.UI2.WinForms.Guna2TextBox pass)
        {
            return string.IsNullOrEmpty(userName.ToString()) || string.IsNullOrEmpty(pass.ToString());
        }
        public static bool isPhoneValid(Int64 phone,int age)
        {
            if (phone.ToString().Length != 9 && phone.ToString().Length != 10)
            {
                return false;
            }
            if (age < 0)
            {
                return false;
            }
            if (age < 18 || age > 66)
            {
                return false;
            }

            return true;
        }
        public static bool isSalaryValid(int salary)
        {
            if(salary < 0)
            {
                return false;
            }
            if(!salary.ToString().All(char.IsDigit))
            {
                return false;
            }

            return true;
        }
        public static void clearTxtBoxes(params Guna.UI2.WinForms.Guna2TextBox[] textBoxes)
        {
            foreach (Guna.UI2.WinForms.Guna2TextBox txt in textBoxes)
            {
                txt.Clear();
            }
        }
        public static void clearCmBox(params Guna.UI2.WinForms.Guna2ComboBox[] combox)
        {
            foreach(Guna.UI2.WinForms.Guna2ComboBox cmbx in combox)
            {
                cmbx.SelectedIndex = -1;
            }
        }
        public static bool isTextBoxEmpty(params Guna.UI2.WinForms.Guna2TextBox[] textBoxes)
        {
            foreach (Guna.UI2.WinForms.Guna2TextBox txt in textBoxes)
            {
                if (txt.ToString() != "" || txt.ToString() != null)
                    return false;
            }
            return true;
        }
    }
}

