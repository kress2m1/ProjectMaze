using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiddenCode.Basics
{
    public class Friday
    {
        /// <summary>
        /// This method returns the student name and this is achieved via an XML comment
        /// </summary>
        /// <param name="newStudentName"></param>
        /// <returns></returns>
        public string GreetNewStudent(string newStudentName)
        {
            Console.WriteLine("The new Student name is " + newStudentName);
            string greetings = "Welcome " + newStudentName + " to Train Centre PLC";
            return greetings;
        }

        /// <summary>
        /// This method when called, returns the acount number and sort code
        /// </summary>
        /// <param name="accountNumber"></param>
        /// <param name="sortCode"></param>
        public void CheckAccountBalance(long accountNumber, string sortCode)
        {
            if ((accountNumber == 124578101) && (sortCode.Equals("20-10-99")))
            {
                Console.WriteLine("Your account balance is £2094.09");
            }
        }
    }
}
