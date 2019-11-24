using System;
using System.Data.SqlClient;
using System.Configuration;

namespace TryToConnectToMyDB
{
    static class SQLClass
    {
        public static void TryToConnect()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = @"Data source = SOME1;
                                            Initial Catalog = mPolishchuk_CSharpAdvanced;
                                            Integrated Security = SSPI;";
             
            try
            {
                connection.Open();
                Console.WriteLine("DB name: " + connection.Database);
            }
            finally
            {
                connection.Close();
            }
        }
        public static void MyUpdate()
        {
            var infoString = @"update Characters set LastName = 'uNdOmIeL' where FirstName = 'Arven'";

            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["mPolishchuk_CSharpAdvanced"].ToString();
                SqlCommand command = new SqlCommand(infoString, connection);
                connection.Open();
                command.ExecuteNonQuery();
            }

        }

    }
}
