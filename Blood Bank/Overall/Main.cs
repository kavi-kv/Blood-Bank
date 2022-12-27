using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Bank.Overall
{
    public class Main:Connection.Connections
    {
        
        //This class servers as general class for the project



        public static DataTable ReadData<T>(T currProc)
        {
            DataTable dt = new DataTable();
            var main = new Main();
            var conn = main.GetSqlConnection();
            conn.Open();
            var cmd = new SqlCommand(currProc.ToString(), conn);
            cmd.CommandType = CommandType.StoredProcedure;
            var adaper = new SqlDataAdapter(cmd);
            adaper.Fill(dt);
            cmd.ExecuteNonQuery();
            conn.Close();
            return dt;
        }

        public static int ReadBloodGroups<T>(T bloodGroup, T currProc)
        {
            var main = new Main();
            var conn = main.GetSqlConnection();
            conn.Open();
            var cmd = new SqlCommand(currProc.ToString(), conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@bloodGroup", SqlDbType.VarChar).Value = bloodGroup.ToString();
            var reader = cmd.ExecuteReader();
            Int64 result = 0;
            while (reader.Read())
            {
                result = Convert.ToInt64(reader[1]);
            }
            return (int)Convert.ToInt64(result);
        }
    }
}
