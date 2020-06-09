using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Employees
    {
        string empName;
        int empAge;
        string deptName;
        Employees(string name, int num)
        {
            empName = name;
            empAge = num;
            deptName = "Eeasearch & dev";
        }
        static void Main(string[] args)
        {
            Employees obj= new Employees(name: "johin", num: 1);
            Console.WriteLine(obj.deptName);
            Console.Read();
        }
    }
}
