using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    public class Rectangle
    {
        double length;
        double breadth;
        public Rectangle() 
            {
                length = 13.5;
                breadth = 20.5;
            }
        public Rectangle(double len, double wide) {
            length = len;
            wide = breadth;
                }
        public double Area()
        {
            return length * breadth;
        }
        public static void Main(string[] args)
        {
            Rectangle obj = new Rectangle();
            Console.WriteLine(obj.Area());
            Rectangle obj2 = new Rectangle(2.5, 6.8);
            Console.WriteLine(obj2.Area());
            Console.Read();
        }
    }
}
