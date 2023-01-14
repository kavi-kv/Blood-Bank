using Blood_Bank.Controller;
using Blood_Bank.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
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

        public static DataTable ReadDonor(string currProc,int phoneNum)
        {
            DataTable dt = new DataTable();
            var conn = new Main().GetSqlConnection();
            conn.Open();
            var cmd = new SqlCommand(currProc.ToString(), conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@phoneNum", phoneNum);
            var adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            cmd.ExecuteNonQuery();
            return dt;
        }
        public static DataTable ReadTrans(string currProc,int trId)
        {
            DataTable dt = new DataTable();
            var conn = new Main().GetSqlConnection();
            conn.Open();
            var cmd = new SqlCommand(currProc.ToString(), conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@trId", trId);
            var adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            cmd.ExecuteNonQuery();
            return dt;
        }
        public static bool isNumberValid(int number)
        {
            var conn = new Main().GetSqlConnection();
            conn.Open();
            var cmd = new SqlCommand("sigleDonorReport", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@phoneNum", number);
            var reader = cmd.ExecuteReader();
            int phone = 0;
            int num = Reports.phoneNum;
            while (reader.Read())
            {
                phone = Convert.ToInt32(reader[3]);
                if (num == phone)
                    return true;
            }
            return false;
        }
        public static bool isTrIdValid(int id)
        {
            var conn = new Main().GetSqlConnection();
            conn.Open();
            var cmd = new SqlCommand("readSingleTrans", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@trId", id);
            var reader = cmd.ExecuteReader();
            int TransId = 0;
            int trId = Reports.transacionId;
            while (reader.Read())
            {
                TransId = Convert.ToInt32(reader[0]);
                if (trId == TransId)
                    return true;
            }
            return false;
        }
        public static DataTable getDataByMonth<T>(T month,T procedure)
        {
            DataTable dt = new DataTable();
            var conn = new Main().GetSqlConnection();
            conn.Open();
            var cmd = new SqlCommand(procedure.ToString(), conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@month",SqlDbType.VarChar).Value = month.ToString();
            var adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            cmd.ExecuteNonQuery();
            conn.Close();
            return dt;
        }
        public static void deleteDonorBlood<T>(T phone)
        {
            var conn = new Main().GetSqlConnection();
            conn.Open();
            var cmd = new SqlCommand("deleteDonorBlood", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@phoneNum", SqlDbType.VarChar).Value = phone.ToString();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void Delete<T>(T target,T CurrProc,string targetFromSql)
        {
            var conn = new Main().GetSqlConnection();
            conn.Open();
            var cmd = new SqlCommand(CurrProc.ToString(), conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue(targetFromSql, SqlDbType.VarChar).Value = target.ToString();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        //public static void Update(string phone, )

        /// <summary>
        /// Reads all users Security Question
        /// </summary>
        /// <param name="combo"></param>
        public static void readSecQuestion(Guna.UI2.WinForms.Guna2ComboBox combo)
        {
            var conn = new Main().GetSqlConnection();
            conn.Open();
            var cmd = new SqlCommand("readExistedSecQ", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            var reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                combo.Items.Add(reader[0].ToString());
            }
            reader.Close();
            conn.Close();
        }

        public void readSecQuestionByEmail(Guna.UI2.WinForms.Guna2ComboBox combo,string email)
        {
            var conn = new Main().GetSqlConnection();
            conn.Open();
            var cmd = new SqlCommand("readExistedSecQByEmail", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@email", email);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                combo.Items.Add(reader[0].ToString());
            }
            reader.Close();
            conn.Close();
        }

        public static int GetTotal(string tableName,string columnName)
        {
            var conn = new Main().GetSqlConnection();
            conn.Open();
            var cmd = new SqlCommand("GetTotal", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tableName", SqlDbType.VarChar).Value = tableName.ToString();
            cmd.Parameters.AddWithValue("@columnName", SqlDbType.VarChar).Value = columnName.ToString();
            var reader = cmd.ExecuteReader();
            int result = 0;
            while(reader.Read())
            {
                result = Convert.ToInt32(reader[0]);
            }
            return result;
        }

        public static int getBloodTotal()
        {
            var conn = new Main().GetSqlConnection();
            conn.Open();
            var cmd = new SqlCommand("totalBloodDonations",conn);
            cmd.CommandType = CommandType.StoredProcedure;
            var reader = cmd.ExecuteReader();
            int result = 0;
            while(reader.Read())
            {
                result = Convert.ToInt32(reader[0]);
            }
            return result;
        }

        public static int Allusers()
        {
            var conn = new Main().GetSqlConnection();
            conn.Open();
            var cmd = new SqlCommand("allUsers", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            var reader = cmd.ExecuteReader();
            int result = 0;
            while(reader.Read())
            {
                result = Convert.ToInt32(reader[0]);
            }
            return result;
        }
        public static int totalStaff()
        {
            var conn = new Main().GetSqlConnection();
            conn.Open();
            var cmd = new SqlCommand("totalStaff", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            var reader = cmd.ExecuteReader();
            int result = 0;
            while(reader.Read())
            {
                result = Convert.ToInt32(reader[0]);
            }
            return result;
        }
        
        public static int pendingBlood()
        {
            var conn = new Main().GetSqlConnection();
            conn.Open();
            var cmd = new SqlCommand("pendinBlood", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            var reader = cmd.ExecuteReader();
            int result = 0;
            while(reader.Read())
            {
                result = Convert.ToInt32(reader[0]);
            }
            return result;
        }

        public static int? readSummary(string currProc)
        {
            var conn = new Main().GetSqlConnection();
            conn.Open();

            var cmd = new SqlCommand(currProc.ToString(), conn);
            cmd.CommandType = CommandType.StoredProcedure;
            var reader = cmd.ExecuteReader();
            int? result = 0;
            while(reader.Read())
            {
                result = Convert.ToInt32(reader[0]);
            }
            return result;
        }

        public static string OndemandBlGroup()
        {
            var conn = new Main().GetSqlConnection();
            conn.Open();
            var cmd = new SqlCommand("OnDemandBlGroup", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            var reader = cmd.ExecuteReader();
            string blgroupName = "";
            while(reader.Read())
            {
                blgroupName = reader[0].ToString();
            }
            return blgroupName;
        }
        public static bool isDonorExist(int phone)
        {
            var conn = new Users().GetSqlConnection();
            conn.Open();
            var cmd = new SqlCommand("isEmailExist", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@phoneNum", phone);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader.HasRows)
                    return true;
            }
            return false;
        }

        public static void loggedIn(string userName)
        {
           // var dash = new Dash();
            var conn = new Main().GetSqlConnection();
            conn.Open();
            var cmd = new SqlCommand("loggedIn", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@userName", userName);
            var reader = cmd.ExecuteReader();
            while(reader.Read())
            {
              Shared.Dash.userId = (int) reader["id"];
              Shared.Dash.fullName = reader["fullName"].ToString();
              Shared.Dash.userName = reader["userName"].ToString();
              Shared.Dash.Email = reader["Email"].ToString();
              Shared.Dash.secQ = reader["securityQuestion"].ToString();
              Shared.Dash.secAns = reader["securityAnswer"].ToString(); 
            }
            reader.Close();
            conn.Close();
        }

        public static void isDonorExistValid(int phone)
        {
            var donor = new DonorBoard();
            var conn = new Users().GetSqlConnection();
            conn.Open();
            var cmd = new SqlCommand("isEmailExist", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@phoneNum", phone);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                
                donor.existedDonorAddress = reader[1].ToString();
                donor.existedDonorBlood = reader[2].ToString();
                donor.existedDonorSex = reader[5].ToString();
            }
            reader.Close();
            conn.Close();
        }
        public static bool isAdmin(string userName)
        {
            var conn = new Main().GetSqlConnection();
            conn.Open();
            var cmd = new SqlCommand("isAdminOrUser", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@userName", userName);
            var reader = cmd.ExecuteReader();
            string role;
            while(reader.Read())
            {
                if (!reader.HasRows)
                    break;
                role = reader["role"].ToString();
                if (role == "Admin")
                    return true;
            }
            return false;
        }
    }
}
