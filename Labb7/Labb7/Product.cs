using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb7
{
    public class Product : ISellable
    {
        public int Price { get; set; }
        public string ProductInformation { get; set; }   
    }
}