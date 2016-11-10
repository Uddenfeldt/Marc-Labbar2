using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb2
{
    public class Parrot : Bird
    {
        public string CanTalk { get; set; }

        public override string Move()
        {
            return String.Format("I can {0}", CanFly);
        }
        public override string Talk()
        {
            return String.Format("I also know how to {0} human language", CanTalk);
        }
    }
}