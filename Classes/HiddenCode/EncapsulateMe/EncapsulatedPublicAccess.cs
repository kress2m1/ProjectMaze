using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiddenCode.EncapsulateMe
{
    //Members can be accessed by code in the same assembly or another assembly that references it
    class EncapsulatedPublicAccess
    {
        //Create a variable visible to the Main method
        public int iPublicVariable;

        //Create a method visible to the Main method
        public void PublicMethod()
        {
            Console.WriteLine("You have accessed the PublicMethod()");
        }

        //A derived class can be used to access the protected class
        class DerivedClass:EncapsulatedProtectedAccess
        {
            public void RevealedProtectedClass()
            {
                //Access the protected members in the derived class
                Console.WriteLine(iProtectedVariable);
            }
             
        }
    }
}
