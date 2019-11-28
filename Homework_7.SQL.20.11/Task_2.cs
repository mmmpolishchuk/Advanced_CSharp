using System;
using System.Configuration;
using System.Data.SqlClient;

namespace Homework_7.SQL._20._11
{
    static class SQL_Connection
    {

        public static void CreateMyTable()
        {
            string requeryString = @"CREATE TABLE [dbo].[MovieZZZ] (
                                     [Name]  NVARCHAR (20)  NOT NULL,
                                     [Genre] NVARCHAR (20)  NOT NULL,
                                     [Year]  INT                NULL,
                                     PRIMARY KEY CLUSTERED ([Name] ASC));";

            using (SqlConnection myConnection = new SqlConnection())
            {
                myConnection.ConnectionString = ConfigurationManager.ConnectionStrings["AdvanceCSharpCS"].ToString();

                SqlCommand myCommand = new SqlCommand(requeryString, myConnection);
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                Console.WriteLine("DB name: " + myConnection.Database);
            }

        }
    }
}

