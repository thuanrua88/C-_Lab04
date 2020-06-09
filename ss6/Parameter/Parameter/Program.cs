using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameter
{
    class OptionalPrmeterExample
    {
        void printfmes(string str = "Hello DDN")
        {
            Console.WriteLine("{0}", str);
        }
    
        static void Main(string[] args)
        {
            OptionalPrmeterExample ope = new OptionalPrmeterExample();
            ope.printfmes();
            Console.Read();
        }
    }
}
