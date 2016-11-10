using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7
{
    class Runtime
    {
        public void Start()
        {
            ProductManager manager = new ProductManager();
            bool loop = true;

            while (loop)
            {
                Console.Clear();
                Menus.PrintMainMenu();

                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        Console.Clear();
                        manager.ShowElectronics();
                        Console.ReadLine();


                        break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        Console.Clear();
                        manager.ShowFood();
                        Console.ReadLine();
                        break;

                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        Console.Clear();
                        manager.ShowToys();
                        Console.ReadLine();
                        break;

                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        Environment.Exit(0);

                        break;

                    default:
                        Console.WriteLine("Press 1,2 or 3 please");
                        break;
                }
            }
        }
    }
}
