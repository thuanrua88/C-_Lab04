﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2MethodOverLoad
{
    class Program
    {
        static int Square(int num)
        {
            return num * num;
        }
        static float Square(float num)
        {
            return num * num;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Square of integer value " +Square(5));
            Console.WriteLine("Square of float value " +Square(2.5F));
        }
    }
}
