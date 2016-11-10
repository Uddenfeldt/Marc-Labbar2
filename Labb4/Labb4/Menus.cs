using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb4
{
    class Menus
    {
        public static void PrintMainMenu()
        {
            Console.WriteLine("Welcome to Marcs Carshop");
            Console.WriteLine("------------------------");
            Console.WriteLine("1. Buy a vehicle ");
            Console.WriteLine("2. Sell a vehicle");
            Console.WriteLine("3. Show all vehicles ");
            Console.WriteLine("4. Exit");
        }
        public static void PrintChoiceMenu()
        {
            Console.WriteLine("What kind of vehicles do you want to see?");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("1. New cars");
            Console.WriteLine("2. Used cars");
            Console.WriteLine("3. New motorcycles");
            Console.WriteLine("4. Used motorcycles");
        }
        public static void PrintAddVehicle()
        {
            Console.WriteLine("What kind of vehicle do you want to add?");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("1. New car");
            Console.WriteLine("2. Used car");
            Console.WriteLine("3. New motorcycle");
            Console.WriteLine("4. Used motorcycle");
        }
        public static void PrintRemoveVehicle()
        {
            Console.WriteLine("What kind of vehicle do you want to remove? ");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("1. New car");
            Console.WriteLine("2. Used car");
            Console.WriteLine("3. New motorcycle");
            Console.WriteLine("4. Used motorcycle");
        }
    }
}
