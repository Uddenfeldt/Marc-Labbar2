using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3
{
    class Runtime
    {
        public void Start()
        {
            Kiss kiss = new Kiss
            {
                 Category = "Concert ",
                 Date = new DateTime(1994,12,25,12,25,00,00),
                 Location = "Wembley Stadium ",
                 NameOfBooker = "Eric ",
                 Band = "Kiss ",
                 Genre = "Rock"

            };
            Dance dance = new Dance
            {
                Category = "Concert ",
                Date = new DateTime (2006,01,18,13,30,00,00),
                Location = "Tele 2 Arena ",
                NameOfBooker = "Gustaf ",
                Band = "Das Boot ",
                Genre = "Dance music"
            };

            MarcsLife marcsLife = new MarcsLife
            {
                NameOfMovie = "Marcs Life",
                Category = "Movie ",
                Date = new DateTime(2012, 05, 12, 12, 00, 00),
                Location = "Stockholm ",
                NameOfBooker = "Göran ",
                Genre = "Comedy "
            };

            Ariel ariel = new Ariel
            {
                NameOfMovie = "Ariel",
                Category = "Movie ",
                Date = new DateTime(1994, 01, 12, 19, 00, 00),
                Location = "Under the sea ",
                NameOfBooker = "Greta ",
            };
           Hultsfred hultsfred = new Hultsfred
            {
                Category = "Party ",
                Date = new DateTime(2006,02,18,15,00,00),
                Location = "Blekinge ",
                NameOfBooker = "Alfred ",
                DurationOfEvent = "1 week "
            };
            Roskilde roskilde = new Roskilde
            {
                Category = "Party ",
                Date = new DateTime(2006, 03, 02, 00, 00, 00, 0),
                Location = "Danmark ",
                NameOfBooker = "Adrian ",
                DurationOfEvent = "1 week "
            };

            List < Concert > concerts = new List<Concert>()
            {
                kiss,
                dance
            };
            List<Movie> movies = new List<Movie>()
            {
                marcsLife,
                ariel
            };
            List<Festival> festivals = new List<Festival>()
            {
                hultsfred,
                roskilde
            };
            bool loop = false;
            do
            {
                Console.WriteLine("Welcome to tickets");
                Console.WriteLine("-------------------------------");
                Console.WriteLine("Please choose any of the below.");
                Console.WriteLine("1. Concerts");
                Console.WriteLine("2. Movies");
                Console.WriteLine("3. Festivals");
                Console.WriteLine("4. Exit");
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Console.Clear();
                        foreach (var item in concerts)
                        {
                            Console.WriteLine("Genre: " + item.Genre + " Band: " + item.Band + "Category: " + item.Category + "Date: " + item.Date + " Location: " + item.Location + "Buyer of ticket: " + item.NameOfBooker);
                        }
                        break;

                    case 2:
                        Console.Clear();
                        foreach (var item1 in movies)
                        {
                            Console.WriteLine("Movies Name: " + item1.NameOfMovie + "Category: " + item1.Category + "Genre: " + item1.Genre + "Date: " + item1.Date + " Location: " + item1.Location + "Buyer of ticket: " + item1.NameOfBooker);
                        }
                        break;

                    case 3:
                        Console.Clear();
                        foreach (var item2 in festivals)
                        {
                            Console.WriteLine("Name of festival: " + item2.NameOfFestival + "Category: " + item2.Category + "Date: " + item2.Date + " Location: " + item2.Location + "Buyer of ticket: " + item2.NameOfBooker);
                        }
                        break;

                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Choose wisely my young padawan");
                        break;
                }

            } while (true);

        }
    }
}
