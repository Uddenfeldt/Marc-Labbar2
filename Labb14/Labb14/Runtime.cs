using Labb14.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb14
{
    class Runtime
    {
        public void Start()
        {
            Book myBook = new Book
            {
                Title = "Tranan",
                Author = new Author { Name = "John", Age = 20 },
                Genre = "Romance",
                Pages = 120,
                ReleaseDate = 1999
            };
            Magazine myMagazine = new Magazine
            {
                Title = "Teknikens värld",
                Author = new Author { Name = "Marc", Age = 25 },
                Genre = "Cars",
                Pages = 100,
                ReleaseDate = 2002
            };
            Paper myPaper = new Paper
            {
                Title = "Dagens Nyheter",
                Author = new Author { Name = "Adrian", Age = 31 },
                Genre = "News",
                Pages = 50,
                ReleaseDate = 1880
            };
            Author myAuthor1 = myBook.Author;

            Author myAuthor2 = myMagazine.Author;

            Author myAuthor3 = myPaper.Author;
            
        }
    }
}
