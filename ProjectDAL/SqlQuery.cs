using System.Configuration;
using System.Data.SqlClient;

namespace ProjectDAL
{
    public class SqlQuery
    {
        public delegate void SetDataReader_delegate(SqlDataReader reader);
        public delegate object SetResulrDataReader_delegate(SqlDataReader reader);
        public static void RunCommand(string sqlQuery, SetDataReader_delegate func)
        {
            //string connectionString = ConfigurationManager.AppSettings["ConnectionStrings"];
            string connectionString = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=marketDB;Data Source=DESKTOP-CNDDP4B\SQLEXPRESS";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string queryString = sqlQuery;

                // Adapter
                using (SqlCommand command = new SqlCommand(queryString, connection))
                {
                    connection.Open();
                    //Reader
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        func(reader);
                    }
                }

            }

        }

        public static object RunCommandResult(string sqlQuery, SetResulrDataReader_delegate func)
        {
            object ret = null;
            //string connectionString = ConfigurationManager.AppSettings["ConnectionStrings"];
            string connectionString = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=marketDB;Data Source=DESKTOP-CNDDP4B\SQLEXPRESS";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string queryString = sqlQuery;

                // Adapter
                using (SqlCommand command = new SqlCommand(queryString, connection))
                {
                    connection.Open();
                    //Reader
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        ret = func(reader);
                    }
                }

            }

            return ret;
        }
    }
}