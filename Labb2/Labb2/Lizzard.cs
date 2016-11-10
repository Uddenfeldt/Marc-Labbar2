using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb2
{
    public class Lizzard : Reptile
    {
        public string CanLooseTail { get; set; }
        public string CanTalk { get; set; }
        public override string Move()
        {
            return String.Format("Im so cool because i can {0}, and i can also {1}", CanLooseTail, CanRun);
        }
        public override string Talk()
        {
            return String.Format("I cant say {0}", CanTalk);
        }
    }
}
