using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Variables
{
    public class VariableTypes
    {
        //This is an instance of a Local variable, which is defined within a method
        public void VarInsideMethod()
        {
            string name = "Andre Dada";
            int age; //A local variable must be initialised. This may cause issues at runtime
        }

        //This is another example of a Local variable, called a parameter variable
        //Here, this is represented by 'int a' and 'int b'
        public double VarParameters(int a, int b)
        {
            double resultAdd = a + b;
            return resultAdd;
        }

        /// <summary>
        /// Check this string out in Program
        /// </summary> You forgot to add the summary
        /// <param name="newString"></param>
        /// <param name="oldString"></param>
        /// <returns></returns>
        public string varString(string newString, string oldString)
        {
            string fullName = newString + " " + oldString;
            return fullName;
        }
    }
}
