using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiddenCode.EncapsulateMe
{
    //Members can only be accessed by code in the same class or in a derived class
    class EncapsulatedProtectedAccess
    {
        protected int iProtectedVariable;

        protected void ProtectedMethod()
        {
            iProtectedVariable = 23;
            Console.WriteLine("The protected variable here is " + iProtectedVariable);
        }

        
    }
}
