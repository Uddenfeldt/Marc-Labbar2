using Labb15.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb15.Classes
{
    class Spaceship : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("Starting Engine");
        }
        public void Stop()
        {
            Console.WriteLine("Stopping the Engine");
        }
        public void Lock()
        {
            Console.WriteLine("Locking doors.....????");
        }
        public void Unlock()
        {
            Console.WriteLine("Unlocking doors.....WTF?!");
        }
    }
}
