using Labb15.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb15.Classes
{
    class Car : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("Starting");
        }
        public void Stop()
        {
            Console.WriteLine("Turning off");
        }
        public void Lock()
        {
            Console.WriteLine("Locking Doors");
        }
        public void Unlock()
        {
            Console.WriteLine("Unlocking Doors");
        }
    }
}
