using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb10
{
    class BookManager
    {
        public List<Book> MyBooks { get; set; }

        public BookManager()
        {
            MyBooks = new List<Book>
            {
                new Book {Title = "en bok som är helt värdelös", Genre = "Fiction", Pages = 500, Price = 2500 },
                new Book {Title = "Kort historia", Genre = "ShortStories", Pages = 10, Price = 50 },
                new Book {Title = "Danskarnas krig", Genre = "Novelbooks", Pages = 50, Price= 150},
                new Book {Title = "Farliga vatten", Genre = "Romance", Pages = 200, Price = 100 },
                new Book {Title = "Flygande Drake", Genre = "Mystery" , Pages = 340, Price = 500 },
                new Book {Title = "Apan och Dansken",Genre = "Romance", Pages = 550, Price = 10 },
                new Book {Title = "Dansken saknar Sverige", Genre = "Fantasy", Pages = 1000, Price = 1500}
                
            };

        }

        public void PrintWhere(BookFilter filter)
        {
            foreach (var book in MyBooks)
            {
                if(filter(book))
                    Console.WriteLine(book.Title);
            }
        }
        
    }
}
