using Microsoft.OData.Edm;
using System;
using System.Configuration;
using System.Data.Linq;

namespace Homework_10.LINQ_to_SQL._27._11
{
    public static class Adding_Directors
    {
        public static void AddDirct()
        {
            DataContext addDirect = new DataContext(ConfigurationManager.ConnectionStrings["ConnectToDb"].ToString());

            addDirect.GetTable<Directors>().InsertOnSubmit(new Directors
            {
                FirstName = "Quentin ",
                LastName = "Tarantino",
                BirthDate = new DateTime(1963, 03, 27)
            });
            addDirect.GetTable<Directors>().InsertOnSubmit(new Directors
            {
                FirstName = "David ",
                LastName = "Fincher",
                BirthDate = new DateTime(1962, 08, 28)
            });
            addDirect.GetTable<Directors>().InsertOnSubmit(new Directors
            {
                FirstName = "Alexander",
                LastName = "Dovzhenko",
                BirthDate = new DateTime(1894, 09, 10)
            });

            addDirect.SubmitChanges();
            Console.WriteLine("Directors added.");
        }





    }
}

