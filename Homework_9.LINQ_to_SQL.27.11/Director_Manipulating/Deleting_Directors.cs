using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_10.LINQ_to_SQL._27._11
{
    public static class Deleting_Directors
    {
        public static void DeleteDirect()
        {
            DataContext deleteDirect = new DataContext(ConfigurationManager.ConnectionStrings["ConnectToDb"].ToString());

            var directToDelete = deleteDirect.GetTable<Directors>().Where(x => x.Id>=1);

            deleteDirect.GetTable<Directors>().DeleteAllOnSubmit(directToDelete);
            deleteDirect.SubmitChanges();

            foreach (var director in directToDelete)
            {
                Console.WriteLine("FirstName: {0}\tLastName: {1}\tBirthDay: {2}",
                    director.FirstName, director.LastName, director.BirthDate);
            }

        }
    }
}
