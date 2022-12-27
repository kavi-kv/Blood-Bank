using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public bool isNumValid(int phone)
        {
            return phone >= 9 && phone <= 10 ;
        }
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
        public static bool isQuantityValid(string quantity)
        {
            if (string.IsNullOrEmpty(quantity))
            {
                return false;
            }
            int qty = Convert.ToInt16(quantity);
            return qty >= 460 && qty < 501;
        }

    }
}
