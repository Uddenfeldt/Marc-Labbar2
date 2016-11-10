using Labb6.Classes;
using Labb6.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6.Interfaces
{
    class Human : INonPlayerCharacter
    {
        
    
        public string Name { get; set; }
       

        public virtual string ObserveCharacter()
        {
            return "you see a person";
        }
       

        public virtual bool Talk()
        {
            Console.WriteLine("{0}: Hi", Name);
            return false;
        }
    }
}
