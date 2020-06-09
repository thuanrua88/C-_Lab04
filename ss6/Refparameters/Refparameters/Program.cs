using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refparameters
{
    class RefParameters
    {
        static void Calculate(ref int numValueOne, ref int numValueTwo)
        {
            numValueOne = numValueTwo * 2;
            numValueTwo = numValueOne * 2;
        }
        static void Main(string[] args)
        {
            int numOne = 10;
            int numTwo = 20;
            Console.WriteLine("value of num1 and Num2 before calling method: " + numOne + ", " + numTwo);
            Calculate(ref numOne, ref numTwo);
            Console.WriteLine("value of num1 and Num2 before calling method: " + numOne + ", " + numTwo);
            Console.Read();
        }
    }
}
