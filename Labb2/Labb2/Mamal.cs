using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb2
{
    public class Mamal : Animal
    {
        public string Kind { get; set; }

        public string CanRun { get; set; }

        public string WarmBlood { get; set; }

        public int NumberOfLegs
        {
            get;

            set;
        }
    }


}