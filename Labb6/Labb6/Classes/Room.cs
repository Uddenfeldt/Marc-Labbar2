using Labb6.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6.Interfaces
{
    class Room : IEnvironment
    {
        List<INonPlayerCharacter> nonPlayerCharacters;
        public List<INonPlayerCharacter> NonPlayerCharacters
        {
            get
            {
                if (nonPlayerCharacters == null) nonPlayerCharacters = new List<INonPlayerCharacter>();
                return nonPlayerCharacters;
            
            }
        }
      public string Description { get; private set; }

        public Room (string description)
        {
            Description = description;
        }

        public void Observe()
        {

            foreach (var nonPlayerCharacter in NonPlayerCharacters)
            {
                Console.WriteLine("You see a ");
            }
        }
    }
}
