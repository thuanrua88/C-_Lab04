using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class Program
    {
        string name;
        int old;

        void input()
        {
            Console.WriteLine("Enter name:");
            name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Endter old:");
            old = Convert.ToInt32(Console.ReadLine());
        }
        void std()
        {
            Console.WriteLine("ur name:" + name);
            Console.WriteLine("ur old:{0}", old);
        }

        static void Main(string[] args)
        {
            Program id = new Program();
            id.input();
            id.std();
            Console.Read();
        }
    }
}
