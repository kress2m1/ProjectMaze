using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HiddenCode.EncapsulateMe;
using HiddenCode.Basics;


namespace HiddenCode
{
    class Program
    {
        static void Main(string[] args)
        {
            EncapsulatedPublicAccess _publicAccessSpecifier = new EncapsulatedPublicAccess();

            //Accessing public members of PublicAccessSpecifier class
            _publicAccessSpecifier.iPublicVariable = 1;
            _publicAccessSpecifier.PublicMethod();

            //Try to access PrivateMethod
            EncapsulatedPrivateAccess _privateAccessSpecifier = new EncapsulatedPrivateAccess();
            //None of the private members or methods will be accessible here

            //Access the methods in class Friday
            Friday returnedName = new Friday();

            //Call method GreetNewStudent in class Friday
            returnedName.GreetNewStudent("Andre Dada");

            //Call method CheckAccounBalance in class Friday
            returnedName.CheckAccountBalance(124578101, "20-10-99");

            //Try to access the ProtectedMethod
            EncapsulatedProtectedAccess _protectedAccessSpecifier = new EncapsulatedProtectedAccess();
            //None of the protected members or variables will be accessible here

            
            Console.ReadKey();
        }
    }
}
