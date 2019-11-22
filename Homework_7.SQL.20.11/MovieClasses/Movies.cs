using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_7.SQL._20._11
{
    static class Movies
    {
        public static List<Movie> GetMovies()
        {
            var characters = new List<Movie>();

            characters.Add(new Movie() { Name = "Mission Imposible", Genre = "Thriller", Year = 1996 });
            characters.Add(new Movie() { Name = "Terminator: Dark fates", Genre = "Action", Year = 2019 });
            characters.Add(new Movie() { Name = "Titanic", Genre = "Disaster film", Year = 1997 });

            return characters;
        }

    }
}
