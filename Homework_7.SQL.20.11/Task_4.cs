using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;

namespace Homework_7.SQL._20._11
{
    static class SelectTable
    {
        public static void ShowMovies()
        {
            var myRequery = @"select * from Movies";

            SqlConnection myConnection = new SqlConnection();
            myConnection.ConnectionString = ConfigurationManager.ConnectionStrings["AdvanceCSharpCS"].ToString();

            SqlCommand sqlCommand = new SqlCommand(myRequery, myConnection);
            myConnection.Open();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Console.WriteLine("\nName: {0}\tGenre: {1}\tYear: {2}", sqlDataReader[0].ToString(), sqlDataReader[1].ToString(), 
                    sqlDataReader[2].ToString());
            }
            myConnection.Close();
        }
    }
}
