using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Tenary
{
    
    public class TenaryExpressions
    {
        private int marks;

        public void TenExpress()
        {
            marks = 50;
            Console.WriteLine(marks < 35 ? "Fail" : "Pass");
        }

    }
}
