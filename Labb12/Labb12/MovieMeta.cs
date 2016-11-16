using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb12
{
    class MovieMeta
    {
        public string MovieName { get; set; }

        public override string ToString()
        {
            return String.Format("{0}", MovieName);
        }
    }
}
