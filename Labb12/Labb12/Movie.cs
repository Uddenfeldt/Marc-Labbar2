﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb12
{
    class Movie
    {
        public string Name { get; set; }
        public string Genre { get; set; }
        public int PlayTime { get; set; }

        public override string ToString()
        {
            return String.Format("{0}", Name);
        }
    }
}
