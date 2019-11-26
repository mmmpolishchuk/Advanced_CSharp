using System;
using System.Data.Entity;

namespace Homework_8.EntityFramework.Migrations._25._11
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer<BookShelfContext>(null);
            //BookShelfService.AddCharacters();
            //BookShelfService.AddSomeCharacters();
            //BookShelfService.DeleteCharacters();

            Console.WriteLine("\t\tCharacters Table");
            BookShelfService.ShowCharacters();

            //BookShelfService.AddMovies();

            Console.WriteLine("\t\tMovies Table");
            BookShelfService.ShowMovies();

            Console.Read();
        }
    }
}
