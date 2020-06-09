using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class Book
    {
        string bookName;
        public string Printf()
        {
            return bookName;
         }
        public void input(string bkName)
        {
            bookName = bkName;
        }
        static void Main(string[] args)
        {

            Book objBook = new Book();
            objBook.input("Dontcare");
            Console.WriteLine(objBook.Printf());
            Console.Read();
        }
    }
}
