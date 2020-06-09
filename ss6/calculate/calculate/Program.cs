using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculate
{
    class Calculate
    {
        public static void Addition (int val1, int val2)
        {
            Console.WriteLine(val1 + val2);
        }
        public void Multiply(int val1, int val2)
        {
            Console.WriteLine(val1 * val2);
        }
    }

    class StaticMethods
    {
        static void Main(string[] args)
        {
            Calculate.Addition(20, 40);
            Calculate objcal = new Calculate();
            objcal.Multiply(10, 20);
            Console.Read();
        }
    }
}
