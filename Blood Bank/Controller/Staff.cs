using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Bank.Controller
{

    public class Staff:Connection.Connections,Overall.QueryyMessages
    {
        public string name { get; set; }
        public string address { get; set; }
        public string gender { get; set; }
        public long phone { get; set; }
        public string staffType { get; set; }
        public int age { get; set; }
        public int salary { get; set; }
        public int idUpdate { get; set; }

        public bool QueryHasError { get ; set ; }
        public string ErrorMessage { get; set; }

        public Staff() { }

       
        public Staff(string name, string address, long phone, string staffType, int age, int salary, string gender)
        {
            this.name = name;
            this.address = address;
            this.phone = phone;
            this.staffType = staffType;
            this.age = age;
            this.salary = salary;
            this.gender = gender;
        }
        /// <summary>
        /// This Constructor Updates the staff by id
        /// </summary>
        public Staff(string name, string address, string gender, long phone, string staffType, int age, int salary, int idUpdate)
        {
            this.name = name;
            this.address = address;
            this.gender = gender;
            this.phone = phone;
            this.staffType = staffType;
            this.age = age;
            this.salary = salary;
            this.gender = gender;
            this.idUpdate = idUpdate;
        }

        public  void updateStaff()
        {
            try
            {
                var conn = new Staff().GetSqlConnection();
                conn.Open();
                var cmd = new SqlCommand("updateStaff", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", idUpdate);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@role", staffType);
                cmd.Parameters.AddWithValue("@age", age);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@salary", salary);
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

        public void addStaff()
        {
            try
            {
                var conn = new Staff().GetSqlConnection();
                conn.Open();
                var cmd = new SqlCommand("addStaff", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@staffRole", staffType);
                cmd.Parameters.AddWithValue("@age", age);
                cmd.Parameters.AddWithValue("@salary", salary);
                cmd.Parameters.AddWithValue("@gender", gender);
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
