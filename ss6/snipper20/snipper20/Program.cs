using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snipper20
{
    class Employee
    {
        private int empID;
        private string empName;
        private int age;
        private double salary;
        Employee(int id, string name, int age, double sal)
        {
            Console.WriteLine("Constructor for Employee called");
            empID = id;
            empName = name;
            age = age;
            salary = sal;
        }
        ~Employee()
        {
            Console.WriteLine("Destructor for Employee called");
        }
       
        static void Main(string[] args)
        {
            Employee OBJ = new Employee(1, "k", 45, 34000);
            Console.WriteLine(OBJ.empID);
            Console.WriteLine("Employee Name: " + OBJ.empName);
            Console.WriteLine("Age: " + OBJ.age);
            Console.WriteLine("Salary: " + .salary);
            Console.Read();
        }
    }
}
