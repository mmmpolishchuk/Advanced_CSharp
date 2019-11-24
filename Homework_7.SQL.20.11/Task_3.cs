using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;

namespace Homework_7.SQL._20._11
{
    static class InsertInTable
    {
        public static void MovieInserting()
        {
            string myRequeryFirst = @"insert into Movies ([Name], [Genre],
                                       [Year]) values('Mission Imposible', 'Thriller', 1996)";
            string myRequerySecond = @"insert into Movies ([Name], [Genre],
                                       [Year]) values('Terminator: Dark fates', 'Action', 2019)";
            string myRequeryThird = @"insert into Movies ([Name], [Genre],
                                       [Year]) values('Titanic', 'Disaster film', 1997)";

            using (SqlConnection myConnection = new SqlConnection())
            {
                myConnection.ConnectionString = ConfigurationManager.ConnectionStrings["AdvanceCSharpCS"].ToString();

                SqlCommand command = new SqlCommand(myRequeryFirst, myConnection);
                SqlCommand commandOne = new SqlCommand(myRequerySecond, myConnection);
                SqlCommand commandTwo = new SqlCommand(myRequeryThird, myConnection);

                myConnection.Open();

                Console.WriteLine("Rows inserted.");
            }
        }
    }
}
