using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication
{
    class Multiplication
    {
        static int valueOne = 10;
        static int product;
        static Multiplication()
        {
            Console.WriteLine("Static constructor");
            product = valueOne * valueOne;
        }
        public static void Method()
        {
            Console.WriteLine("value of product= " + product);
        }
    
        static void Main(string[] args)
        {
            Multiplication.Method();
            Console.Read();
        }
    }
}
