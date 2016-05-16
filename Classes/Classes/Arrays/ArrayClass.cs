using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Arrays
{
    public class ArrayClass
    {
        /*
         * Arrays are collections of items which have the same data type
         * An array index starts at zero
         * An array, in a simple declaration can be:
         * int[] intArray;
         */

        public void ArraySamples()
        {
            //A dynamic array doesn't have a fixed length and grows as required
            string[] dynamicStringArray = new string[] { "India", "USA", "Nigeria", "UK" };

            //A fixed length array can't be longer than what was initialised (4, in this instance)
            string[] fixedStringArray = new string[4] { "USA", "Nigeria", "UK", "China" };

            Console.WriteLine(dynamicStringArray[2]);
            Console.WriteLine("..................");
            Console.WriteLine(fixedStringArray[1]);
            Console.WriteLine("..................");
            for (int a = 0; a < dynamicStringArray.Length-1 ; a++)
            {
                Console.WriteLine(a);
            }
           
        }
    }
}
