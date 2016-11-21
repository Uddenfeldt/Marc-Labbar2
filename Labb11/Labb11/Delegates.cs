using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb11
{
    class Delegates
    {
        public delegate void AnalyzeNumber(int n);
        public event AnalyzeNumber NumberInput;

        public void Start()
        {
            // Event handlers
            NumberInput += new AnalyzeNumber(IsEven);
            NumberInput += new AnalyzeNumber(IsDivisableByThree);
            NumberInput += new AnalyzeNumber(IsPrimeNumber);

            int number = int.Parse(Console.ReadLine());

            NumberInput.Invoke(number);
        }

        public void IsEven(int n)
        {
            if (n % 2 == 0)
            {
                Console.WriteLine("The number is Even");
            }
            else
            {
                Console.WriteLine("The number is not even");
            }
            
        }
        public void IsDivisableByThree(int n)
        {
            if ((n % 3) == 0)
            {
                Console.WriteLine("You can divide this by three");
            }
            else
            {
                Console.WriteLine("You can not divide this by 3");
            }
        }
        public void IsPrimeNumber(int n)
        {
            if (n == 1)
                Console.WriteLine("Its not a prime number");
            if (n == 2)
                Console.WriteLine("This is a prime number");

            var boundary = (int)Math.Floor(Math.Sqrt(n));

            for (int i = 2; i <= boundary; ++i)
            {
                if (n % i == 0)
                    Console.WriteLine("Its not a prime number");
            }

            Console.WriteLine("This is a prime number");

            //if (true)
            //{
            //    Console.WriteLine("This is a prime number");
            //}
            //else
            //{
            //    Console.WriteLine("Its not a prime number");
            //}

        }
    }
}
