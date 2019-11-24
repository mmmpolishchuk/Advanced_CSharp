using System.Collections.Generic;
using EntityFrameworkLesson.Models;
using System;

namespace Homework_8.EntityFramework._25._11
{
    public class BookShelfService
    {
        private List<Character> GetCharacters()
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
        public void AddCharacters()
        {
            var dbContext = new BookShelfContext();
            List<Character> characters = GetCharacters();

            dbContext.Characters.AddRange(characters);
            dbContext.SaveChanges();
        }
        public void AddSomeCharacters()
        {
            var dbContext = new BookShelfContext();
            dbContext.Characters.Add(new Character() { FirstName = "Mark", LastName = "Zuckerberg", Gender = true, Age = 35 });
            dbContext.Characters.Add(new Character() { FirstName = "Joseph ", LastName = "Bezos", Gender = true, Age = 55 });

            dbContext.SaveChanges();

            Console.WriteLine("Characters added.");
        }
        public void GetCharactersFromDb()
        {
            var dbContext = new BookShelfContext();
            var characters = dbContext.Characters;

            foreach (var c in characters)
                Console.WriteLine("Id: {0},  \tFirstName: {1}  " +
                    "\tLastName: {2}  \tGender: {3}  \tAge: {4}", c.Id, c.FirstName, c.LastName, c.Gender, c.Age);
        }
    }
}
