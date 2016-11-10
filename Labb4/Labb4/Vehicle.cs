using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb4
{
    public abstract class Vehicle
    {
        public enum VehicleType
        {
            NewCar,
            UsedCar,
            NewMotorcycle,
            UsedMotorcycle
        };

        public int Price { get; set; }


        public string Brand { get; set; }


        public string Model { get; set; }

    }
}