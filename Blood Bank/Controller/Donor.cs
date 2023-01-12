using Blood_Bank.Overall;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Bank.Controller
{
    public class Donor:Connection.Connections
    {
        public string name { get; set; }
        public string bloodType { get; set; }
        public long phoneNum { get; set; }
        public string address { get; set; }
        public string sex { get; set; }
        public DateTime dateOfDonation { get; set; }
        public int quantity { get; set; }
        public int donorAge { get; set; }

        public Donor() { }
        public Donor(string name,string bloodType, long phoneNum,string address,string sex,DateTime dateOfDonation,int quantity,int donorAge) 
        {
            this.name = name;
            this.bloodType = bloodType;
            this.phoneNum = phoneNum;
            this.address = address;
            this.sex = sex;
            this.dateOfDonation = dateOfDonation;
            this.quantity = quantity;
            this.donorAge = donorAge;
        }

        
        public bool QueryHasError { get; set; }
        public string ErrorMessage { get ; set; }


        /// <summary>
        /// The Procedure 'AddDonorAndBlood' -> will add the data both the tables Donor and Blood
        /// </summary>
        public void RegisterDonor()
        {
            try
            {
                var donor = new Donor();
                var conn = donor.GetSqlConnection();
                conn.Open();
                var cmd = new SqlCommand("AddDonorAndBlood", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name",name);
                cmd.Parameters.AddWithValue("@bloodType",bloodType);
                cmd.Parameters.AddWithValue("@phoneNum",phoneNum);
                cmd.Parameters.AddWithValue("@address",address);
                cmd.Parameters.AddWithValue("@sex",sex);
                cmd.Parameters.AddWithValue("@dateOfDonation",dateOfDonation);
                cmd.Parameters.AddWithValue("@quantity",quantity);
                cmd.Parameters.AddWithValue("@age", donorAge);
                cmd.ExecuteNonQuery();
                QueryHasError = false;
                conn.Close();
            }
            catch(SqlException ex)
            {
                QueryHasError = true;
                ErrorMessage = ex.Message;
            }
        }


    }
}
