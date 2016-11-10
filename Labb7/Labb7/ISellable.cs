using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb7
{
    public interface ISellable
    {
        int Price { get; set; }
        string ProductInformation { get; set; }
    }
}