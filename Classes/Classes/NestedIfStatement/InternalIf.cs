using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.NestedIfStatement
{
    public class InternalIf
    {
        private double grade;
        public void ifElse()
        {
            Console.WriteLine("Please enter a grade");
            grade = double.Parse(Console.ReadLine());

            if (grade >= 35)
            {
                if (grade >= 60)
                {
                    Console.WriteLine("First class");
                }
                else
                {
                    Console.WriteLine("Second class");
                }
            }
            else
            {
                Console.WriteLine("Fail");
            }

            int a = 10;
            do
            {
               Console.WriteLine("Next count is " + a);
                a++;
            } while (a < 12);
        }
    }
}
