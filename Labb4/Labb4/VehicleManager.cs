using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb4
{
    class VehicleManager
    {

        public List<NewCar> NewCars { get; set; }
        public List<UsedCar> UsedCars { get; set; }
        public List<NewMotorcycle> NewMotorcycles { get; set; }
        public List<UsedMotorcycle> UsedMotorcycles { get; set; }
        public VehicleManager()
        {
            NewCars = new List<NewCar>
            {
                new NewCar { Brand = "Volvo", Model = "V90", Price = 300 },
                new NewCar { Brand = "Saab", Model = "903", Price = 250 },
            };
            UsedCars = new List<UsedCar>
            {
                new UsedCar { Brand = "BMW", Model = "320", Price = 20 },
                new UsedCar { Brand = "Audi", Model = "A4", Price = 29 }
            };
            NewMotorcycles = new List<NewMotorcycle>
            {
                new NewMotorcycle { Brand = "Suzuki", Model = "GT500", Price = 150 },
                new NewMotorcycle { Brand = "Kawasaki", Model = "BX600", Price = 120 }
            };
            UsedMotorcycles = new List<UsedMotorcycle>
            { 
            new UsedMotorcycle { Brand = "BMW", Model = "XH750", Price = 35 },
                new UsedMotorcycle { Brand = "Suzuki", Model = "GKH100", Price = 32 }
            };


    }


    public void PrintNewCars()
    {


        Console.Clear();
        foreach (var newCar in NewCars)
        {
            Console.WriteLine("{0}, {1}, {2}", newCar.Price, newCar.Brand, newCar.Model);
        }
        Console.ReadLine();
    }

    public void PrintUsedCars()
    {

       

        Console.Clear();
        foreach (var usedCar in UsedCars)
        {
            Console.WriteLine("{0}, {1}, {2}", usedCar.Price, usedCar.Brand, usedCar.Model);
        }
        Console.ReadLine();
    }

    public void PrintNewMotorcycles()
    {
        
        Console.Clear();
        foreach (var newmotorcycle in NewMotorcycles)
        {
            Console.WriteLine("{0}, {1}, {2}", newmotorcycle.Price, newmotorcycle.Brand, newmotorcycle.Model);
        }
        Console.ReadLine();
    }

    public void PrintUsedMotorcycles()
    {
        
        Console.Clear();
        foreach (var usedmotorcycle in UsedMotorcycles)
        {
            Console.WriteLine("{0}, {1}, {2}", usedmotorcycle.Price, usedmotorcycle.Brand, usedmotorcycle.Model);
        }
        Console.ReadLine();
    }

    public void PrintChoice()
    {
        Console.Clear();
        List<NewCar> newCars = NewCars;
        Menus.PrintChoiceMenu();

        var choice = Console.ReadKey(true).Key;

        switch (choice)
        {
            case ConsoleKey.D1:
            case ConsoleKey.NumPad1:
                PrintNewCars();
                break;

            case ConsoleKey.D2:
            case ConsoleKey.NumPad2:
                PrintUsedCars();
                break;

            case ConsoleKey.D3:
            case ConsoleKey.NumPad3:
                PrintNewMotorcycles();
                break;

            case ConsoleKey.D4:
            case ConsoleKey.NumPad4:
                PrintUsedMotorcycles();
                break;

            default:
                break;
        }
    }

    public void AddVehicle()
    {
        Console.Clear();
        List<NewCar> newCars = NewCars;
        List<UsedCar> usedCars = UsedCars;
        List<NewMotorcycle> newMotorcycles = NewMotorcycles;
        List<UsedMotorcycle> usedMotorcycles = UsedMotorcycles;

        Menus.PrintAddVehicle();

        var addChoice = Console.ReadKey(true).Key;

        switch (addChoice)
        {
            case ConsoleKey.D1:
            case ConsoleKey.NumPad1:

                NewCar newCar = new NewCar();
                Console.WriteLine("What brand is it: ");
                newCar.Brand = Console.ReadLine();

                Console.WriteLine("What model is it: ");
                newCar.Model = Console.ReadLine();

                Console.WriteLine("What is the price: ");
                newCar.Price = int.Parse(Console.ReadLine());
                newCars.Add(newCar);
                break;

            case ConsoleKey.D2:
            case ConsoleKey.NumPad2:

                UsedCar usedCar = new UsedCar();
                Console.WriteLine("What brand is it: ");
                usedCar.Brand = Console.ReadLine();

                Console.WriteLine("What model is it: ");
                usedCar.Model = Console.ReadLine();

                Console.WriteLine("What is the price: ");
                usedCar.Price = int.Parse(Console.ReadLine());
                usedCars.Add(usedCar);

                break;

            case ConsoleKey.D3:
            case ConsoleKey.NumPad3:

                NewMotorcycle newMotorcycle = new NewMotorcycle();
                Console.WriteLine("What brand is it: ");
                newMotorcycle.Brand = Console.ReadLine();

                Console.WriteLine("What model is it: ");
                newMotorcycle.Model = Console.ReadLine();

                Console.WriteLine("What is the price: ");
                newMotorcycle.Price = int.Parse(Console.ReadLine());
                newMotorcycles.Add(newMotorcycle);
                break;

            case ConsoleKey.D4:
            case ConsoleKey.NumPad4:

                UsedMotorcycle usedMotorcycle = new UsedMotorcycle();
                Console.WriteLine("What brand is it: ");
                usedMotorcycle.Brand = Console.ReadLine();

                Console.WriteLine("What model is it: ");
                usedMotorcycle.Model = Console.ReadLine();

                Console.WriteLine("What is the price: ");
                usedMotorcycle.Price = int.Parse(Console.ReadLine());
                usedMotorcycles.Add(usedMotorcycle);
                break;
        }
    }

    public void RemoveVehicle()
    {
        Console.Clear();
        List<NewCar> newCars = NewCars;
        List<UsedCar> usedCars = UsedCars;
        List<NewMotorcycle> newMotorcycles = NewMotorcycles;
        List<UsedMotorcycle> usedMotorcycles = UsedMotorcycles;
        Menus.PrintRemoveVehicle();


        var removeChoice = Console.ReadKey(true).Key;

        switch (removeChoice)
        {
            case ConsoleKey.D1:
            case ConsoleKey.NumPad1:
                Console.Clear();

                Console.WriteLine("Enter the number of the vehicle you want to remove: ");

                foreach (var newCar in NewCars)
                {
                    Console.WriteLine("{3}. {1}. {2}. {0}", newCar.Brand, newCar.Model, newCar.Price,
                        Array.IndexOf(newCars.ToArray(), newCar),
                        newCar);
                }

                var index = int.Parse(Console.ReadLine());
                NewCars.RemoveAt(index);
                Console.WriteLine("Vehicle removed");
                Console.ReadKey(true);




                break;
            case ConsoleKey.D2:
            case ConsoleKey.NumPad2:
                Console.Clear();

                Console.WriteLine("Enter the number of the vehicle you want to remove: ");

                foreach (var usedCar in UsedCars)
                {
                    Console.WriteLine("{3}. {1}. {2}. {0}", usedCar.Brand, usedCar.Model, usedCar.Price,
                        Array.IndexOf(usedCars.ToArray(), usedCar),
                        usedCar);
                }
                var index2 = int.Parse(Console.ReadLine());
                UsedCars.RemoveAt(index2);
                Console.WriteLine("Vehicle removed");
                Console.ReadKey(true);

                break;

            case ConsoleKey.D3:
            case ConsoleKey.NumPad3:
                Console.Clear();

                Console.WriteLine("Enter the number of the vehicle you want to remove: ");

                foreach (var newMotorcycle in NewMotorcycles)
                {
                    Console.WriteLine("{3}. {0}. {1}. {2}", newMotorcycle.Brand, newMotorcycle.Model, newMotorcycle.Price,
                        Array.IndexOf(newMotorcycles.ToArray(), newMotorcycle),
                        newMotorcycle);
                }
                var index3 = int.Parse(Console.ReadLine());
                NewMotorcycles.RemoveAt(index3);
                Console.WriteLine("Vehicle removed");
                Console.ReadKey(true);
                break;

            case ConsoleKey.D4:
            case ConsoleKey.NumPad4:
                Console.Clear();

                Console.WriteLine("Enter the number of the vehicle you want to remove: ");

                foreach (var usedMotorcycle in UsedMotorcycles)
                {
                    Console.WriteLine("{3}. {1}. {2}. {0}", usedMotorcycle.Brand, usedMotorcycle.Model, usedMotorcycle.Price,
                        Array.IndexOf(usedMotorcycles.ToArray(), usedMotorcycle),
                        usedMotorcycle);
                }
                var index4 = int.Parse(Console.ReadLine());
                UsedMotorcycles.RemoveAt(index4);
                Console.WriteLine("Vehicle removed");
                Console.ReadKey(true);
                break;
        }
    }
}
}