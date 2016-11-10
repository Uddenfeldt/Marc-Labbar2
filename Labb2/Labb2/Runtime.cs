using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2
{
    class Runtime
    {
        public void Start()
        {
            Dog myDog = new Dog
            {
                Age = 5 ,
                Weight = 80 ,
                WarmBlood = "Yes ",
                CanRun = "Run ",
                NumberOfLegs = 4 ,
                CanBark = "Bark "
            };


            Monkey myMonkey = new Monkey
            {
                Age = 20 ,
                Weight = 50 ,
                WarmBlood = "Yes",
                CanRun = "Run",
                NumberOfLegs = 2,
                CanClimb = "I can climb "
            };
            Snake mySnake = new Snake
            {
                Age = 10 ,
                Weight = 50 ,
                ColdBlood = "Yes ",
                CanRun = "Run ",
                NumberOfLegs = 0 ,
                CanBite = "can bite ",
                CanTalk = "Fzzz"
            };
            Lizzard myLizzard = new Lizzard
            {
                Age = 8 ,
                Weight = 5 ,
                ColdBlood = "Yes ",
                CanRun = "run ",
                NumberOfLegs = 4 ,
                CanLooseTail = "Loose my tail ",
                CanTalk = "Nothing"
            };
            Parrot myParrot = new Parrot
            {
                Age = 80 ,
                Weight = 30 ,
                WarmBlood = "yes ",
                CanFly = "Fly ",
                NumberOfLegs = 2,
                CanTalk = "Talk"
            };
            Eagle myEagle = new Eagle
            {
                Age = 20,
                Weight = 50 ,
                WarmBlood = "Yes ",
                CanFly = "fly",
                NumberOfLegs = 2 ,
                CanHunt = "Hunt "
                
            };

            List<Mamal> mamals = new List<Mamal>()
            {
                myDog,
                myMonkey
            };
            List<Reptile> reptiles = new List<Reptile>()
            {
                mySnake,
                myLizzard
            };
            List<Bird> birds = new List<Bird>()
            {
                myParrot,
                myEagle
            };
            bool loop = false;
            do
            {
                loop = false;
                Console.WriteLine("Welcome to your animal collection");
                Console.WriteLine("------------------------------");
                Console.WriteLine("1: Add new");
                Console.WriteLine("2: Remove");
                Console.WriteLine("3: Show info");
                Console.WriteLine("4: Show Special ability");
                Console.WriteLine("5: Exit");
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Console.WriteLine("What kind of animal do you want to add?");
                        Console.WriteLine("1. Mamal");
                        Console.WriteLine("2. Reptile");
                        Console.WriteLine("3. Bird");
                        int choice = int.Parse(Console.ReadLine());

                        if (choice == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("What kind of mamal is it? ");
                            string kind = Console.ReadLine();

                            Console.WriteLine("What age is it? ");
                            int age = int.Parse(Console.ReadLine());

                            Console.WriteLine("What is its weight?");
                            int weight = int.Parse(Console.ReadLine());

                            Console.WriteLine("Can it run?");
                            string canRun = Console.ReadLine();

                            Console.WriteLine("Number of legs?");
                            int numberOfLegs = int.Parse(Console.ReadLine());

                            Console.WriteLine("Is it warmblood?");
                            string warmBlood = Console.ReadLine();

                            Mamal newMamal = new Mamal()
                            {
                                Kind = kind,
                                Age = age,
                                Weight = weight,
                                CanRun = canRun,
                                NumberOfLegs = numberOfLegs,
                                WarmBlood = warmBlood


                            };

                            mamals.Add(newMamal);
                        }
                        else if (choice == 2)
                        {
                            Console.Clear();
                            Console.WriteLine("What kind of reptile is it? ");
                            string kind = Console.ReadLine();

                            Console.WriteLine("What age is it? ");
                            int age = int.Parse(Console.ReadLine());

                            Console.WriteLine("What is its weight?");
                            int weight = int.Parse(Console.ReadLine());

                            Console.WriteLine("Can it run?");
                            string canRun = Console.ReadLine();

                            Console.WriteLine("Number of legs?");
                            int numberOfLegs = int.Parse(Console.ReadLine());

                            Console.WriteLine("Is it coldblood?");
                            string ColdBlood = Console.ReadLine();

                            Reptile newReptile = new Reptile
                            {
                                Kind = kind,
                                Age = age,
                                Weight = weight,
                                CanRun = canRun,
                                NumberOfLegs = numberOfLegs,
                                ColdBlood = ColdBlood
                            };
                            reptiles.Add(newReptile);
                        }
                        else if (choice == 3)
                        {
                            Console.Clear();
                            Console.WriteLine("What kind of bird is it? ");
                            string kind = Console.ReadLine();

                            Console.WriteLine("What age is it? ");
                            int age = int.Parse(Console.ReadLine());

                            Console.WriteLine("What is its weight?");
                            int weight = int.Parse(Console.ReadLine());

                            Console.WriteLine("Can it fly?");
                            string canFly = Console.ReadLine();

                            Console.WriteLine("Number of legs?");
                            int numberOfLegs = int.Parse(Console.ReadLine());

                            Console.WriteLine("Is it warmblood?");
                            string warmBlood = Console.ReadLine();

                            Bird newBird = new Bird
                            {
                                Kind = kind,
                                Age = age,
                                Weight = weight,
                                CanFly = canFly,
                                NumberOfLegs = numberOfLegs,
                                WarmBlood = warmBlood
                            };
                            birds.Add(newBird);
                        }
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("What kind of animal do you want to remove?");
                        Console.WriteLine("------------------------------------------");
                        Console.WriteLine("1. Mamal");
                        Console.WriteLine("2. Reptile");
                        Console.WriteLine("3. Bird");
                        int toManySwitches = int.Parse(Console.ReadLine());
                        switch (toManySwitches)
                        {
                            case 1:
                                Console.WriteLine("Choose a number");
                                foreach (var mamal in mamals)
                                {
                                    Console.WriteLine("Kind: " + mamal.Kind + " Age: " + mamal.Age + " Weight:  " + mamal.Weight + " Can it run? " + mamal.CanRun + " Number of legs? " + mamal.NumberOfLegs + " Is it warmblooded? " + mamal.WarmBlood);
                                }
                                int index = int.Parse(Console.ReadLine());
                                index = index - 1;
                                mamals.RemoveAt(index);
                                break;

                            case 2:
                                Console.WriteLine("Choose a number");
                                foreach (var reptile in reptiles)
                                {
                                    Console.WriteLine("Kind: " + reptile.Kind + " Age: " + reptile.Age + " Weight:  " + reptile.Weight + " Can it run? " + reptile.CanRun + " Number of legs? " + reptile.NumberOfLegs + " Is it warmblooded? " + reptile.ColdBlood);
                                }
                                int index1 = int.Parse(Console.ReadLine());
                                index1 = index1 - 1;
                                reptiles.RemoveAt(index1);
                                break;

                            case 3:
                                Console.WriteLine("Choose a number");
                                foreach (var bird in birds)
                                {
                                    Console.WriteLine("Kind: " + bird.Kind + " Age: " + bird.Age + " Weight:  " + bird.Weight + " Can it run? " + bird.CanFly + " Number of legs? " + bird.NumberOfLegs + " Is it warmblooded? " + bird.WarmBlood);
                                }
                                int index2 = int.Parse(Console.ReadLine());
                                index2 = index2 - 1;
                                birds.RemoveAt(index2);
                                break;
                                
                            default:
                                Console.WriteLine("Choose 1,2 or 3 asshole");
                                break;
                        }
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Which animals do you want to see?");
                        Console.WriteLine("---------------------------------");
                        Console.WriteLine("1. Mammals");
                        Console.WriteLine("2. Reptiles");
                        Console.WriteLine("3. Birds");
                        int thirdchoice = int.Parse(Console.ReadLine());


                        if (thirdchoice == 1)

                            foreach (var mamal in mamals)
                            {
                                Console.WriteLine("Kind: " + mamal.Kind + " Age: " + mamal.Age + " Weight:  " + mamal.Weight + " Can it run? " + mamal.CanRun + " Number of legs? " + mamal.NumberOfLegs + " Is it warmblooded? " + mamal.WarmBlood);

                            }

                        else if (thirdchoice == 2)

                            foreach (var reptile in reptiles)
                            {
                                Console.WriteLine("Kind: " + reptile.Kind + " Age: " + reptile.Age + " Weight:  " + reptile.Weight + " Can it run? " + reptile.CanRun + " Number of legs? " + reptile.NumberOfLegs + " Is it warmblooded? " + reptile.ColdBlood);
                            }
                        else if (thirdchoice == 3)

                            foreach (var bird in birds)
                            {
                                Console.WriteLine("Kind: " + bird.Kind + " Age: " + bird.Age + " Weight:  " + bird.Weight + " Can it run? " + bird.CanFly + " Number of legs? " + bird.NumberOfLegs + " Is it warmblooded? " + bird.WarmBlood);
                            }
                        break;


                    case 4:
                        Console.WriteLine("Wich animals special ability do you want to see?");
                        Console.WriteLine("1. Dog");
                        Console.WriteLine("2. Monkey");
                        Console.WriteLine("3. Snake");
                        Console.WriteLine("4. Lizzard");
                        Console.WriteLine("5. Parrot");
                        Console.WriteLine("6. Eagle");
                        int fourthchoice = int.Parse(Console.ReadLine());

                        if (fourthchoice == 1)
                        {
                            Console.Clear();
                            Console.WriteLine(" ");
                            Console.WriteLine(myDog.Move());
                            Console.WriteLine(myDog.Talk());
                            Console.WriteLine(" ");
                          
                        }
                       else if (fourthchoice == 2)
                        {
                            Console.Clear();
                            Console.WriteLine(" ");
                            Console.WriteLine(myMonkey.Move());
                            Console.WriteLine(myMonkey.Talk());
                        }
                        else if (fourthchoice == 3)
                        {
                            Console.Clear();
                            Console.WriteLine(" ");
                            Console.WriteLine(mySnake.Move());
                            Console.WriteLine(mySnake.Talk());
                        }
                        else if (fourthchoice == 4)
                        {
                            Console.Clear();
                            Console.WriteLine(" ");
                            Console.WriteLine(myLizzard.Move());
                            Console.WriteLine(myLizzard.Talk());
                        }
                        else if (fourthchoice == 5)
                        {
                            Console.Clear();
                            Console.WriteLine(" ");
                            Console.WriteLine(myParrot.Move());
                            Console.WriteLine(myParrot.Talk());
                        }
                        else if (fourthchoice == 6)
                        {
                            Console.Clear();
                            Console.WriteLine(" ");
                            Console.WriteLine(myEagle.Move());
                            Console.WriteLine(myEagle.Talk());
                        }

                        break;
                    case 5:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Pick wisely my fucking bro");
                        
                        break;
                }
            } while (true);




        }

    }

}


