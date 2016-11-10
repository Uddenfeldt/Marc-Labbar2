using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb8G
{
    class Runtime
    {
        public delegate void stringConCatinator(string[] array);
        public delegate void numberOperator(float[] collection);
        CollectionManager myObj = new CollectionManager();

        public void DelegateStrings(string[] array)
        {
            foreach (var word in myObj.MyArray)
            {
                Console.Write(word + ",");
            }
        }


        public void Start()
        {
            stringConCatinator sConc = new stringConCatinator(DelegateStrings);
            sConc(myObj.MyArray);
            Console.WriteLine();
            Func<float, float, float> addFloats = (n1, n2) =>
        
            {
                return (n1 + n2 -0.2f);
            };
            myObj.Calculator(addFloats);
            Console.WriteLine();
            Func<float, float, float> multiplicationFloats = (n1, n2) =>

            {
                return n1 * n2;
            };
            myObj.Calculator(multiplicationFloats);
           
        }
    }
}
