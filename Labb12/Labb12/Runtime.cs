using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb12
{
    class Runtime
    {
        public void Start()
        {
            List<Movie> movies = new List<Movie>()
            {
                new Movie {Name = "Danskarna", Genre = "Action", PlayTime = 80 },
                new Movie {Name = "Svenskarna som dödar danskar", Genre = "Action", PlayTime = 200 },
                new Movie {Name = "Vi älskar Danmark", Genre = "Romantik", PlayTime = 125 },
                new Movie {Name = "Dansa Dansk", Genre = "SciFi", PlayTime = 95 }
            };
            Movie singleMovie = movies.SingleOrDefault(movie => String.Equals(movie.ToString(), "Danskarna"));
            Console.WriteLine("Specifik Movie");
            string output;
            if (singleMovie != null)
                output = singleMovie.ToString();
            else

                output = "No Matches";

            Console.WriteLine(output);

            Movie[] subset = movies
                .Where(person => person.Genre.Contains("Action"))
                .ToArray();
            Console.WriteLine("Action Movies");
            foreach (var movie in subset)
            {
                
                Console.WriteLine("Where : {0}", movie.ToString());
            }
            Movie[] playTime = movies
                .Where(movie => movie.PlayTime > 120)
                .ToArray();

            Console.WriteLine("Long movies: ");
            foreach (var movie in playTime)
            {
                Console.WriteLine("{0}", movie.ToString());
            }
                

        }
    }
}
