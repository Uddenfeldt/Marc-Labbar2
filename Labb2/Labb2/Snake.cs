using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb2
{
    public class Snake : Reptile
    {
        
        public string CanBite{ get; set; }
        public string CanTalk { get; set; }

        public override string Move()
        {
            return String.Format("Unfortunatley i cant {0}, but i can {1}", CanRun,CanBite);
        }
        public override string Talk()
        {
            return String.Format("I can say {1}", CanTalk);
        }
    }
}
