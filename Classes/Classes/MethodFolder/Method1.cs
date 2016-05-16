using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.MethodFolder
{
    public class Method1
    {
        //Create some variables here
        int eyeSight;
        double legRun;
        
        //Declare the different methods here

        //This is a SMART method
        public void Eyes()
        {
            Console.WriteLine("I can see with my eyes");
        }

        public void Leg()
        {
            Console.WriteLine("I can run with my legs");
        }

        //This is a SMART method
        public void AdderSmart()
        {
            int x = 3;
            int y = 5;
            int result = x + y;
            Console.WriteLine(result);
        }

        //This is a SMARTER method
        public void AdderSmarter(int a, int b)
        {
            int ansSmarter = a + b;
            Console.WriteLine(ansSmarter);
        }

        //This is the SMARTEST method. Nothing is returned from this method unless explictly specified
        public double AdderSmartest(int a, int b)
        {
            double ansSmartest = a + b;
            return ansSmartest;
        }
    }
}
