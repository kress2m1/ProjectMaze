using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Classes.SharpTraining
{
    public class SquareRoot
    {
        private double rootNumber, squaredNumber;

        public void squareTheNumber()
        {
            Console.WriteLine("Please enter the number to be squared");
            rootNumber = double.Parse(Console.ReadLine());

            squaredNumber = rootNumber*rootNumber;

            Console.WriteLine("The square root of " + rootNumber + " is " + squaredNumber);

        }
    }
}
