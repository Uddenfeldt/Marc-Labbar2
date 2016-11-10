using Labb6.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6.Classes
{
    class MyList
    {
        static List<IEnvironment> environments;

        public static List<IEnvironment> Enviroments
        {
            get
            {
                if (environments == null)
                    environments = new List<IEnvironment>();

                return environments;
            }
        }
    }
}
