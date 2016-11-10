using Labb6.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6.Classes
{
    class WorldCreator : IEnvironment
    {
        public string Description { get; set; }
        
        public List<INonPlayerCharacter> NonPlayerCharacters { get; set; }
        

        public void Observe()
        {
            throw new NotImplementedException();
        }
    }
}
