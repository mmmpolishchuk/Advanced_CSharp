using System;
using System.Collections.Generic;
using System.Linq;
using EntityFrameworkLesson.Models;



namespace Homework_8.EntityFramework.Migrations._25._11
{
    public static class BookShelfService
    {
        private static List<Character> GetCharacters()
        {
            var characters = new List<Character>();

            characters.Add(new Character() { FirstName = "Finn", LastName = "Mertens", Gender = true, Age = 14 });
            characters.Add(new Character() { FirstName = "Philip", LastName = "Fry", Gender = true, Age = 25 });
            characters.Add(new Character() { FirstName = "Arven", LastName = "Undomiel", Gender = false, Age = 2700 });
            characters.Add(new Character() { FirstName = "Audrey", LastName = "Hepburn", Gender = false, Age = 29 });
            characters.Add(new Character() { FirstName = "John", LastName = "Wick", Gender = true, Age = 42 });
            characters.Add(new Character() { FirstName = "Anakin", LastName = "Skywalker", Gender = true, Age = 29 });
            characters.Add(new Character() { FirstName = "Princess", LastName = "Bubblegum", Gender = false, Age = 827 });
            characters.Add(new Character() { FirstName = "Svetlana", LastName = "Sokolova", Gender = false, Age = 45 });
            characters.Add(new Character() { FirstName = "Varian", LastName = "Wrynn", Gender = true, Age = 42 });
            characters.Add(new Character() { FirstName = "Harry", LastName = "Seldon", Gender = true, Age = 35 });

            return characters;
        }
        public static void AddCharacters()
        {
            var dbAddCharacters = new BookShelfContext();
            List<Character> characters = GetCharacters();

            dbAddCharacters.Characters.AddRange(characters);
            dbAddCharacters.SaveChanges();
            Console.WriteLine("Characters added.");
        }
        public static void ShowCharacters()
        {
            var dbShowCharacters = new BookShelfContext();
            var characters = dbShowCharacters.Characters;

            foreach (var c in characters)
            {
                Console.WriteLine("Id: {0}\t First Name: {1}\t Last Name: {2}\t Gender: {3}\t Age: {4}",
                    c.Id, c.FirstName, c.LastName, c.Gender, c.Age);
            }
        }
        public static void DeleteCharacters()
        {
            var dbDeleteCharacters = new BookShelfContext();
            var deleteCharactres = dbDeleteCharacters.Characters.Where(x => x.Id > 10);

            dbDeleteCharacters.Characters.RemoveRange(deleteCharactres);
            dbDeleteCharacters.SaveChanges();
        }
        public static void AddSomeCharacters()
        {
            var dbAddSomeCharacters = new BookShelfContext();

            List<Character> addCharacters = new List<Character>()
            {
                new Character { FirstName = "Bill", LastName = "Gates", Gender = true, Age = 63 },
                new Character { FirstName = "Elon", LastName = "Musk", Gender = true, Age = 48 }
            };

            dbAddSomeCharacters.Characters.AddRange(addCharacters);
            dbAddSomeCharacters.SaveChanges();
            Console.WriteLine("Some characters added.");
        }
        private static List<Movie> GetMovies()
        {
            var movies = new List<Movie>();

            movies.Add(new Movie() { Name = "Titanic", Genre = "Film disaster", Year = 1997 });
            movies.Add(new Movie() { Name = "The Revenant", Genre = "Dramatic", Year = 2016 });
            movies.Add(new Movie() { Name = "The Shawshank Redemption", Genre = "Thriller", Year = 1994 });
            movies.Add(new Movie() { Name = "The Fate of the Furious", Genre = "Action", Year = 2017 });
            movies.Add(new Movie() { Name = "Joker", Genre = "Thriller", Year = 2019 });

            return movies;
        }
        public static void AddMovies()
        {
            var dbAddMovies = new BookShelfContext();
            List<Movie> movies = GetMovies();

            dbAddMovies.Movies.AddRange(movies);
            dbAddMovies.SaveChanges();
            Console.WriteLine("Movies added.");
        }
        public static void ShowMovies()
        {
            var dbShowMovies = new BookShelfContext();
            var movies = dbShowMovies.Movies;

            foreach (var m in movies)
            {
                Console.WriteLine("Id: {0}\t Name: {1}\t Genre: {2}\t Year: {3}",
                    m.Id, m.Name, m.Genre, m.Year);
            }
        }
    }
}
