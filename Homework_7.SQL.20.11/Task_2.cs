using System;
using System.Data.SqlClient;

namespace Homework_7.SQL._20._11
{
    static class SQL_Connection
    {
        public static void CreateConnection()
        {
            SqlConnection myConnection = new SqlConnection();
            myConnection.ConnectionString =
                @"Data Source = SOME1; 
                    Initial Catalog = mPolishchuk_CSharpAdvanced;
                       Integrated Security = SSPI;";

            try
            {
                myConnection.Open();
                Console.WriteLine("DB name: " + myConnection.Database);
            }
            finally
            {
                myConnection.Close();
            }
        }
       
       

    }
}
