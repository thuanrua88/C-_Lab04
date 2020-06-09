using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace outParameters
{
    class Program
    {
        static void Deprectication(out int val)
        {
            val = 2000;
            int dep = val * 5 / 100;
            int amt = val - dep;
            Console.WriteLine("Amout: " + dep);
        }
        static void Main(string[] args)
        {
            int value;
            Deprectication(out value);
            Console.Read();
        }
    }
}
