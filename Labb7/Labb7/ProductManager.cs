using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7
{
    class ProductManager
    {
        public List<Electronics> Electronics { get; set; }
        public List<Food> Foods { get; set; }

        public List<Toys> Toys { get; set; }

        public ProductManager()
        {
            Electronics = new List<Electronics>()
            {
                new Electronics {Price = 300, ProductInformation = "Speaker " },
                new Electronics {Price = 250, ProductInformation = "Mp3 " }
            };

            Foods = new List<Food>()
            {
                new Food { Price = 25, ProductInformation = "Kaffe "},
                new Food {Price = 50, ProductInformation = "Rib Eye " }
            };

            Toys = new List<Toys>()
            {
                new Toys {Price = 400, ProductInformation = "Board Game" },
                new Toys {Price = 5000, ProductInformation = "Electric Car " }
            };
        }

        public void ShowElectronics()
        {
            foreach (var electronic in Electronics)
            {
                Console.WriteLine("Price: " +  electronic.Price+ " " + "Information: " + electronic.ProductInformation);
                
            }
            
        }
        public void ShowFood()
        {
            foreach (var food in Foods)
            {
                Console.WriteLine("Price: "+ food.Price + " " + "Information: " + food.ProductInformation);
            }
        }

        public void ShowToys()
        {
            foreach (var toy in Toys)
            {
                Console.WriteLine("Price: " +  toy.Price + " " + "Information: " + toy.ProductInformation);
            }
        }
        
    }
}
