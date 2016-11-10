using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Runtime
    {
        public static void PrintMenus()
        {
            Menus.TillAgnes();

            

            var choice = Console.ReadKey(true).Key;
            switch (choice)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:

                    Menus.KärleksFörklaring();
                    Console.ReadLine();
                    return;
                    break;

                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Välj antingen 1 eller 2 älskling <3");
                    break;
            }
        }
    }
}
