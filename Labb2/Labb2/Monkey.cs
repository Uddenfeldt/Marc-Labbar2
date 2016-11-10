using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb2
{
    public class Monkey : Mamal
    {
        public string CanClimb{get;set;}
        public string CanLaugh { get; set; }
        public override string Move()
        {
            return String.Format("I can {0} and {1}", CanRun, CanClimb);
        }

        public override string Talk()
        {
            return String.Format("I can also {1}", CanLaugh);
        }

    }
}