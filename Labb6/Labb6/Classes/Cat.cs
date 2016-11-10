using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6.Classes
{
    class Cat : Animal
    {
        public Cat(string name = "Greta") : base(name)
        {

        }

        public override bool Talk()
        {
            Console.WriteLine("The Cat avoids you");
            return false;
        }
    }
}
