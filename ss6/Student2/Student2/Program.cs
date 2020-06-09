using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student2
{
    class Student
    {
        void printfname(string firstname, string lastName)
        {
            Console.WriteLine("Fist name: {0}, last Name: {1}", firstname, lastName);
        }

        static void Main(string[] args)
        {
            Student student = new Student();
            student.printfname("dc", lastName: "DN");
            Console.Read();
        }
    }
}
