using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            string mystr;
            int i;
            Console.Write("Enter your name: ");
            mystr = Convert.ToString(Console.ReadLine());
            Console.Write("How old are you? ");
            i = Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();
           
        }
    }
}
