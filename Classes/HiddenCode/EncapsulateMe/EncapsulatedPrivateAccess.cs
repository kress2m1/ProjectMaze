using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiddenCode.EncapsulateMe
{
    //Members can only be accessed by code in the same class
    class EncapsulatedPrivateAccess
    {
        protected int iPrivateVariable;

        protected void PrivateMethod()
        {
            //Leave this blank for now 
            iPrivateVariable = 12;
        }
    }
}
