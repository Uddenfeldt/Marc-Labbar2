using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb8G
{
    class CollectionManager
    {
        public string[] MyArray { get; set; }
        public float[] MyCollection { get; set; }


        public CollectionManager()
        {
            MyArray = new string[]
            {
                "fittja",
                "trosa",
                "handen",
                "danskjävel",
                "svennebanan"
            };

            MyCollection = new float[]
            {
                12.18f,18.54f,19.91f,19.90f,18.25f

            };
        }
        public void Calculator(Func<float,float,float> calcFunc)
        {
            float total = 1;
            foreach (var number in MyCollection)
            {
                total = calcFunc(total, number);
            }
            Console.WriteLine(total);
        }
        
    }
}
