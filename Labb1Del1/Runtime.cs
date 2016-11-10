using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1Del1
{
    class Runtime
    {
        public void Start()
        {
            Dog dog1 = new Dog
            {
                Name = "göran",
                Age = 10,
                Breed = "Labrador"
            };
            Dog dog2 = new Dog
            {
                Name = "spartacus",
                Age = 2,
                Breed = "Chihuahua"
            };
            Dog dog3 = new Dog
            {
                Name = "Kexet",
                Age = 3,
                Breed = "mastiff"
            };
            List<Dog> dogs = new List<Dog>()
            {
                dog1,
                dog2,
                dog3
            };
            
            foreach (var dog in dogs)
            {
                Console.WriteLine(dog.Name + " " + dog.Age + " " + dog.Breed);
            }
            bool loop = false;
            do
            {
                loop = false;
                Console.WriteLine("Welcome to our dogcollection");
                Console.WriteLine("----------------------------");
                Console.WriteLine("1. Add new dog");
                Console.WriteLine("2. Remove dog");
                Console.WriteLine("3. Show info");
                Console.WriteLine("4. Exit");
                var input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Dogs Name");
                        string name = Console.ReadLine();
                        Console.WriteLine("Dogs Age");
                        int age = int.Parse(Console.ReadLine());
                        Console.WriteLine("Dogs breed");
                        string breed = Console.ReadLine();

                        
                        Dog newDog = new Dog
                        {
                            Name = name,
                            Age = age,
                            Breed = breed,

                        };
                        dogs.Add(newDog);
                        break;
                    case 2:
                        Console.WriteLine("What dog do you want to remove?");
                        int index = int.Parse(Console.ReadLine());
                        index = index - 1;
                        dogs.RemoveAt(index);
                        
                        
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Show all your dogs");
                        foreach (var dog in dogs)
                        {
                            Console.WriteLine(dog.Name + " " + dog.Age + " " + dog.Breed);
                        }
                     break;

                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Please listen you dumb fuck and press 1-4");
                        
                        break;
                }

            } while (true);
        }

    }
}
