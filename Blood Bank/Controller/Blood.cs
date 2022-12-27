using Blood_Bank.Overall;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Bank.Controller
{
    public class Blood : Connection.Connections, Overall.QueryyMessages
    {

        public int donorNum { get; set; }
        public string donorName { get; set; }
        public string status { get; set; }  

        private string bloodGroup { get; set; }
        private int bloodId { get; set; }
        private double quantity { get; set; }

        public Blood() { }

        public Blood(int bloodId, double quantity, string bloodGroup)
        {
            this.bloodId = bloodId;
            this.quantity = quantity;
            this.bloodGroup = bloodGroup;
        }

        public bool QueryHasError { get; set; }
        public string ErrorMessage { get; set; }

        public void AddtoBBank()
        {
            try
            {
                var conn = GetSqlConnection();
                conn.Open();
                var cmd = new SqlCommand("AddToBloodBank", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@bloodId", bloodId);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.Parameters.AddWithValue("@bloodGroup", bloodGroup);
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
