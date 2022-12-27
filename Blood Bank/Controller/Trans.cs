using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Bank.Controller
{
    public class Trans : Connection.Connections, Overall.QueryyMessages
    {
        public int id { get; set; }
        public double quantity { get; set; }
        public string bloodGroup { get; set; }
        public string hospitalName { get; set; }
        public string staffName { get; set; }
        public string type { get; set; }
        public bool QueryHasError { get; set; }
        public string ErrorMessage { get; set; }

        public Trans() { }
        public Trans(int id, double quantity, string bloodGroup, string type, string hospitalName, string staffName)
        {
            this.id = id;
            this.quantity = quantity;
            this.bloodGroup = bloodGroup;
            this.type = type;
            this.hospitalName = hospitalName;
            this.staffName = staffName;
        }

        public void addToTr()
        {
            try
            {
                var conn = GetSqlConnection();
                conn.Open();
                var cmd = new SqlCommand("TransactionBlood", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@bBankId", id);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.Parameters.AddWithValue("@bloodGroup", bloodGroup);
                cmd.Parameters.AddWithValue("@trType", type);
                cmd.Parameters.AddWithValue("@trTo", hospitalName);
                cmd.Parameters.AddWithValue("@trName", staffName);
                cmd.ExecuteNonQuery();
                QueryHasError = false;
                conn.Close();

            }
            catch (SqlException ex)
            {
                QueryHasError = true;
                ErrorMessage = ex.Message;
            }
        }
    }
}
