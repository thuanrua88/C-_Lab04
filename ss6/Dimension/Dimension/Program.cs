﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dimension
{
    class Dimension
    {
        double length;
        double breadth;
        public double Area(double length, double breadth)
        {
            this.length = length;
            this.breadth = breadth;
            return length * breadth;
        }
        static void Main(string[] args)
        {
            Dimension obj = new Dimension();
            
            Console.WriteLine(obj.Area(10.5, 12.5));
            Console.Read();
        }
    }
}
