using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb4
{
    class Runtime
    {
        public void Start()
        {
            VehicleManager manager = new VehicleManager();

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
                        manager.AddVehicle();

                        break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        manager.RemoveVehicle();

                        break;

                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        manager.PrintChoice();

                        break;

                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
