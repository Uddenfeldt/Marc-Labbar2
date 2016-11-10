using Labb6.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6.Interfaces
{
    class Yard : IEnvironment
    {
        public  string Description { get; set; }

        List<INonPlayerCharacter> nonPlayerCharacters;
        public List<INonPlayerCharacter> NonPlayerCharacters
        {
            get
            {
                if (nonPlayerCharacters == null) nonPlayerCharacters = new List<INonPlayerCharacter>();
                return nonPlayerCharacters;
            }
        }
        public void Observe()
        {
            Console.WriteLine("You see a ");
        }
    }
}
