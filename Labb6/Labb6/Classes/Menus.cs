using Labb6.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6.Classes
{
    class Menus
    {
        public static void Introduction()
        {
            Console.WriteLine("Welcome to my Adventure game");
            Console.WriteLine("----------------------------");
            Console.WriteLine("1. Start game");
            Console.WriteLine("2. How to");
            Console.WriteLine("3. Exit");
        }

        public static void HowTo()
        {
            Console.WriteLine("How to");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("You play the game and you are happy.");
            Console.WriteLine("If youre not happy i will kill you");
        }
    }
}
