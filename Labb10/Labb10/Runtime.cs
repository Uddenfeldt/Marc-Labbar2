using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb10
{
    class Runtime
    {

        public void Start()
        {
            BookManager manager = new BookManager();

            BookFilter IsNovelFilter = BookFilters.IsNovel;
            BookFilter IsShortStoryFilter = BookFilters.IsShortStory;
            BookFilter IsGenreMysteryFilter = BookFilters.IsGenreMystery;
            BookFilter IsGenreFantasyFilter = BookFilters.IsGenreFantasy;
            BookFilter IsGenreRomanceFilter = BookFilters.IsGenreRomance;
            BookFilter IsGenreFictionFilter = BookFilters.IsGenreFiction;
            BookFilter IsCheapFilter = BookFilters.IsCheap;
            BookFilter IsExpensiveFilter = BookFilters.IsExpensive;

            Console.WriteLine("Novel: ");
            manager.PrintWhere(IsNovelFilter);

            Console.WriteLine("\nShort Story: ");
            manager.PrintWhere(IsShortStoryFilter);

            Console.WriteLine("\nMystery: ");
            manager.PrintWhere(IsGenreMysteryFilter);

            Console.WriteLine("\nFantasy: ");
            manager.PrintWhere(IsGenreFantasyFilter);

            Console.WriteLine("\nRomance: ");
            manager.PrintWhere(IsGenreRomanceFilter);

            Console.WriteLine("\nFiction: ");
            manager.PrintWhere(IsGenreFictionFilter);

            Console.WriteLine("\nCheap Books: ");
            manager.PrintWhere(IsCheapFilter);

            Console.WriteLine("\n Expensive books; ");
            manager.PrintWhere(IsExpensiveFilter);
        }
    }
}
