using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Homework_7.SQL._20._11
{
    static class InsertInTable
    {
        public static void MovieInserting()
        {
            //string myRequery = @"insert into Movies ([Name], [Genre],*/
            //[Year]) values('Mission Imposible', 'Thriller', 1996)";
            string myRequeryOne = @"insert into Movies ([Name], [Genre],
                              [Year]) values('Terminator: Dark fates', 'Action', 2019)";
            string myRequeryTwo = @"insert into Movies ([Name], [Genre],
                              [Year]) values('Titanic', 'Disaster film', 1997)";

            SqlConnection myConnection = new SqlConnection();
            myConnection.ConnectionString = @"Data Source = SOME1; 
                    Initial Catalog = mPolishchuk_CSharpAdvanced;
                    Integrated Security = SSPI;";

            //SqlCommand command = new SqlCommand(myRequery, myConnection);
            SqlCommand commandOne = new SqlCommand(myRequeryOne, myConnection);
            SqlCommand commandTwo = new SqlCommand(myRequeryTwo, myConnection);

            try
            {
                myConnection.Open();
                //var insertedRow = command.ExecuteNonQuery();
                var insertedRowOne = commandOne.ExecuteNonQuery();
                var insertedRowTwo = commandTwo.ExecuteNonQuery();
                Console.WriteLine("Rows inserted: " + "\t" + /*insertedRow + "\t" +*/ insertedRowOne + "\t" + insertedRowTwo);
            }
            finally
            {
                myConnection.Close();
            }
        }
    }
}
