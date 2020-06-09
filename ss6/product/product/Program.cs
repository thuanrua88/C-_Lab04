using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace product
{
    public static class Product {
        static int productID;
        static double price;
        static Product(){
            productID = 10;
            price = 30.33;
        }
        public static void display()
        {
            Console.WriteLine("Product id:{0}", productID);
            Console.WriteLine("Price: {0}", price);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Product.display();
            Console.Read();
        }
    }
}
