using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Bank.Controller
{
    public class BBank : Connection.Connections, Overall.QueryyMessages
    {
        public string bloodType { get; set; }   
        public int orders { get; set; }   
        public bool QueryHasError { get ; set; }
        public string ErrorMessage { get; set ; }

        public BBank() { }
        public BBank(string bloodType, int orders)
        {
            this.bloodType = bloodType;
            this.orders = orders;
        }


        public void AddToBloodBank()
        {
            try
            {
                var conn = GetSqlConnection();
                conn.Open();
                var cmd = new SqlCommand("", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("", bloodType);
                cmd.Parameters.AddWithValue("",orders);
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
