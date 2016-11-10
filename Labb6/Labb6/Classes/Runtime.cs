using Labb6.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6.Classes
{
    class Runtime
    {
        public void Start()
        {
            Menus.Introduction();
            var input = Console.ReadKey(true).Key;
            switch (input)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    
                    break;

                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    Console.Clear();
                    Menus.HowTo();
                    Console.ReadLine();
                    break;

                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Click right you dumbass");
                    break;
            }
        }
    }
}
