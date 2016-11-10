using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1Del1
{
    class Dog
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Breed { get; set; }
        public string WriteDogs()
        {
            return string.Format("here are your dogs {0}, {1}, {2}", Name, Age, Breed);
        }
        
    }
}
