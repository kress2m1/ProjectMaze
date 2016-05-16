using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Classes.InstVariable
{
    public class VariableInstanceType
    {
        //Instance variables are defined outside methods and are available to all methods
        private int x = 4;
        private int y = 34;

        public void VarAdd()
        {
            double z = x + y;
            Console.WriteLine("The sum of x & y is: " + z);
        }

    }
}
