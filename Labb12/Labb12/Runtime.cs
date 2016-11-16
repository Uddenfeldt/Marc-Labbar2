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
                new Movie {Name = "Danskarna", Genre = "Action", PlayTime = 180 },
                new Movie {Name = "Svenskarna som dödar danskar", Genre = "Action", PlayTime = 200 },
                new Movie {Name = "Vi älskar Danmark", Genre = "Romantik", PlayTime = 125 },
                new Movie {Name = "Dansa Dansk", Genre = "SciFi", PlayTime = 95 }
            };
            Movie singleMovie = movies.SingleOrDefault(movie => String.Equals(movie.ToString(), "Danskarna"));
            Console.WriteLine("i");
            string output;
            if (singleMovie != null)
                output = singleMovie.ToString();
            else

                output = "No Matches";

            Console.WriteLine(output);

            Movie[] subset = movies
                .Where(person => person.Genre.Contains("Action"))
                .ToArray();
            Console.WriteLine("ii");
            foreach (var movie in subset)
            {

                Console.WriteLine("Where : {0}", movie.ToString());
            }
            Movie[] playTime = movies
                .Where(movie => movie.PlayTime > 120)
                .ToArray();

            Console.WriteLine("iii");
            foreach (var movie in playTime)
            {
                Console.WriteLine("{0}", movie.ToString());
            }

            MovieMeta[] movieMeta = movies
                .Select(movie => new MovieMeta { MovieName = movie.ToString() })
                .ToArray();

            Console.WriteLine("iv");
            foreach (var movie in movieMeta)
            {
                Console.WriteLine("{0}", movie.ToString());
            }

            MovieMeta[] name = movies
                 .Select(Movie => new MovieMeta { MovieName = movies.ToString() })
                 .ToArray();
            string[] allNames = movies
                .Where(movie => String.Equals(movie.Name, "Dansa Dansk"))
                .Select(movie => movie.Name)
                .ToArray();

            Console.WriteLine("v");
            foreach (var movie in allNames)
            {
                Console.WriteLine("{0}", movie.ToString());
            }

            Movie[] thatMovie = movies
                .Where(movie => movie.Name.StartsWith("D") && movie.PlayTime > 120 && movie.Genre.Contains("Action"))
                .ToArray();

            Console.WriteLine("vi");
            foreach (var movie in thatMovie)
            {
                Console.WriteLine("{0}", movie.Name);
            }
        }
    }
}


//Hämta alla filmer vars namn börjar på A(eller någon annan bokstav om du vill), har en speltid över 120 minuter och hör till en specifik genre.