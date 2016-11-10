using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb2
{
    public class Eagle : Bird
    {
        public string CanHunt { get; set; }

        public override string Move()
        {
            return String.Format("I can {0}",CanFly);
        }
        public override string Talk()
        {
            return String.Format("I can also {0}", CanHunt);
        }
    }
}