using Blood_Bank.Connection;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Bank.Controller
{
    public class Users : Connection.Connections,Overall.QueryyMessages
    {
        public string fullName { get; set; }
        public string email { get; set; }
        public string role { get; set; }
        public string secQuestion { get; set; }
        public string secAnswer { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public int idUpdater { get; set; }
        public bool QueryHasError { get ; set ; }
        public string ErrorMessage { get ; set ; }

        public Users() { }

        public Users(string fullName,string password)
        {
            this.userName = userName;
            this.password = password;
        }
        public Users(string fullName, string email, string role,string userName,string password ,string secQuestion, string secAnswer)
        {
            this.fullName = fullName;
            this.email = email;
            this.role = role;
            this.userName = userName;
            this.password = password;
            this.secQuestion = secQuestion;
            this.secAnswer = secAnswer;
        }
        public Users(string fullName, string email, string userName, string secQuestion, string secAnswer, int idUpdater)
        {
            this.fullName = fullName;
            this.email = email;
            this.userName = userName;
            this.secQuestion = secQuestion;
            this.secAnswer = secAnswer;
            this.idUpdater = idUpdater;
        }
        public void addUserAsAdmin()
        {
            try
            {
                var user = new Users();
                var conn = user.GetSqlConnection();
                conn.Open();
                var cmd = new SqlCommand("addUser", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fullName", fullName);
                cmd.Parameters.AddWithValue("@userName", userName);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@role",role);
                cmd.Parameters.AddWithValue("@password",password);
                cmd.Parameters.AddWithValue("@secQ",secQuestion);
                cmd.Parameters.AddWithValue("@secA", secAnswer);
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
        public void addUser()
        {
            try
            {
                var user = new Users();
                var conn = user.GetSqlConnection();
                conn.Open();
                var cmd = new SqlCommand("addUser", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fullName", fullName);
                cmd.Parameters.AddWithValue("@userName", userName);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@role",role);
                cmd.Parameters.AddWithValue("@password",password);
                cmd.Parameters.AddWithValue("@secQ",secQuestion);
                cmd.Parameters.AddWithValue("@secA", secAnswer);
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

        public void updateUserViewInfo()
        {
            var conn = new Users().GetSqlConnection();
            conn.Open();
            var cmd = new SqlCommand("userUpdate", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@fullName", fullName);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@userName", userName);
            cmd.Parameters.AddWithValue("@secQ", secQuestion);
            cmd.Parameters.AddWithValue("@secAns", secAnswer);
            cmd.Parameters.AddWithValue("@id", idUpdater);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        /// <summary>
        /// Checks the existance of the admin -> it return rows if the admin exists (true) or it rerurns empty/no row if admin doesn't exist
        /// </summary>
        /// <returns></returns>
        public static bool CheckAdminExistence()
        {
            var user = new Users();
            SqlConnection connection = new Users().GetSqlConnection();
            
                connection.Open();

                SqlCommand command = new SqlCommand("isExistAdmin", connection);
                command.CommandType = CommandType.StoredProcedure;

                var result =  command.ExecuteReader();
                while (result.Read())
                {
                    if (result.HasRows)
                        return true;
                }
                return false;
        }
        public static bool isEmailExist<T>(T email)
        {
            var conn = new Users().GetSqlConnection();
            conn.Open();
            var cmd = new SqlCommand("isEmailExist", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@email",email); 
            var reader = cmd.ExecuteReader();   
            while(reader.Read())
            {
                if(reader.HasRows)
                    return true;
            }
            return false;   
        }
        /// <summary>
        /// This is the login function -> it executes the LoginCredentials procedure 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool LoginCredentials<T>(T userName,T password) 
        {
            var conn = new Users().GetSqlConnection();
            conn.Open();
            var cmd = new SqlCommand("LoginCredentials", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@userName", userName);
            cmd.Parameters.AddWithValue("@password", password);
            var reader = cmd.ExecuteReader();
            while (reader.Read()) 
            {
                if (reader.HasRows)
                    return true;
            }
            return false;
        }
        /// <summary>
        /// Changes the password by using users email
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="email"></param>
        /// <param name="pass"></param>
        public  void changePassByEmail(string email,string pass)
        {
            try
            {
                var conn = new Users().GetSqlConnection();
                conn.Open();
                var cmd = new SqlCommand("changePass", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@pass", pass);
                cmd.ExecuteNonQuery();
                QueryHasError = false;
                conn.Close();
            }
            catch (Exception ex) 
            {
                QueryHasError = true;
                ErrorMessage = ex.Message;
            }
        }
        /// <summary>
        /// Changes the password by using users security question and answer
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="secQ"></param>
        /// <param name="secAnswer"></param>
        /// <param name="pass"></param>
        public void changePassBySecQ<T>(string secQ,string secAnswer ,string pass)
        {
            try
            {
                var conn = new Users().GetSqlConnection();
                conn.Open();
                var cmd = new SqlCommand("changePassBySecQ", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@secQ", secQ);
                cmd.Parameters.AddWithValue("@secAns", secAnswer);
                cmd.Parameters.AddWithValue("@pass", pass);
                cmd.ExecuteNonQuery();
                QueryHasError = false;
                conn.Close();
            }
            catch (Exception ex)
            {
                QueryHasError = true;
                ErrorMessage = ex.Message;
            }
        }
        /// <summary>
        /// -> returns true if the returned rows from the table(securityQuestion and securityAnswer) match the input of the user's security Question
        /// </summary>
        /// <param name="email"></param>
        /// <param name="secQ"></param>
        /// <param name="secAns"></param>
        /// <returns></returns>
        /// 

        public static string question;
        public static string answer;
        public static bool isSecQandSecAnsValid(string currEmail,string secQ,string secAns)
        {
            var isvalid = false;
            var conn = new Users().GetSqlConnection();
            conn.Open();
            var cmd = new SqlCommand("isSecQandAnsValid".ToString(), conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@email", currEmail);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
               
                if (reader.HasRows)
                {
                    question = reader[0].ToString();
                    answer = reader[1].ToString();
                   

                    if (question.Equals(secQ) && answer.Equals(secAns))
                        isvalid= true;
                }
            }
            return isvalid;
        }
    }
}
