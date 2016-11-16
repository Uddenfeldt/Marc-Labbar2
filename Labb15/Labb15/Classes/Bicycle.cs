using Labb15.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb15.Classes
{
    class Bicycle : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("Start");
        }
        public void Stop()
        {
            Console.WriteLine("Stopping");
        }
        public void Lock()
        {
            Console.WriteLine("Locking the bike");
        }
        public void Unlock()
        {
            Console.WriteLine("Unlocking the bike");
        }

    }
}
