using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Classes.MethodFolder;
using Classes.Constructors;
using Classes.Variables;
using Classes.InstVariable;
using Classes.SharpTraining;
using Classes.NestedIfStatement;
using Classes.Arrays;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an object of class Method1
            Method1 person = new Method1();

            //Call method Eyes
            person.Eyes();
            Console.WriteLine(".............");

            //Call method Leg
            person.Leg();
            Console.WriteLine(".............");
            Console.WriteLine("I was added online here"");

            //Call method AdderSmart
            person.AdderSmart();
            Console.WriteLine(".............");

            //Call method AdderSmarter
            person.AdderSmarter(100, 230);
            Console.WriteLine(".............");

            //Call method AdderSmartest
            person.AdderSmartest(210, 150);
            Console.WriteLine();
            Console.WriteLine(".............");

            //This is the method created in Main and can be called by it's name without the need to create an object
            externalMethodInMain();

            //Call method VariableTypes here
            VariableTypes varMethod = new VariableTypes();

            varMethod.VarInsideMethod();
            Console.WriteLine(".............");

            double varD = varMethod.VarParameters(200, 162);
            Console.WriteLine("varD is equal to: " + varD);
            Console.WriteLine(".............");

            VariableInstanceType varInst = new VariableInstanceType();
            varInst.VarAdd();
            Console.WriteLine(".............");

            SquareRoot mathSquare = new SquareRoot();
            mathSquare.squareTheNumber();
            Console.WriteLine(".............");

            InternalIf testIf = new InternalIf();
            testIf.ifElse();
            Console.WriteLine(".............");

            //Call the array class here
            ArrayClass viewArrays = new ArrayClass();
            viewArrays.ArraySamples();
            Console.WriteLine(".............");


            Console.ReadKey();
        }

        //A method can also be declared here and run in the program
        public static void externalMethodInMain()
        {
            Console.WriteLine("This is a method called in the Main method");
        }       
    }
}
