using System;
using System.Configuration;
using System.Data.SqlClient;

namespace Homework_7.SQL._20._11
{
    static class SQL_Connection
    {

        public static void CreateMyTable()
        {
            string requeryString = @"CREATE TABLE [dbo].[MovieS] (
                                     [Name]  NVARCHAR (20)  NOT NULL,
                                     [Genre] NVARCHAR (20)  NOT NULL,
                                     [Year]  INT                NULL,
                                     PRIMARY KEY CLUSTERED ([Name] ASC));";

            using (SqlConnection myConnection = new SqlConnection())
            {
                myConnection.ConnectionString =
                                               @"Data Source = SOME1; 
                                               Initial Catalog = mPolishchuk_CSharpAdvanced;
                                               Integrated Security = SSPI;";

                //myConnection.ConnectionString = ConfigurationManager.ConnectionStrings["AdvanceCSharpCS"].ToString();
                SqlCommand myCommand = new SqlCommand(requeryString, myConnection);
                myConnection.Open();
                Console.WriteLine("DB name: " + myConnection.Database);
            }
        }
    }
}

