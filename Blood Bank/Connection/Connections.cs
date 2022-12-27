using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Bank.Connection
{
    public class Connections
    {
        public  SqlConnection GetSqlConnection()
        {
            string dtabaseName = "BB.mdf";
            string actualPath = AppDomain.CurrentDomain.BaseDirectory.ToLower().Replace("\\bin", "").Replace("\\debug", "").Trim('\\');
            string pathName = Path.GetFullPath(Environment.CurrentDirectory);
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + actualPath + @"\" + dtabaseName + ";Integrated Security=True";
            var sqlConnection = new SqlConnection(connectionString);

            return sqlConnection;
        }
    }
}
