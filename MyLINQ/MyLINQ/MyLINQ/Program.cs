using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyLINQ.Controller;

namespace MyLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            DoTestClass.ShowDoTest();
            Console.WriteLine();
            UsersClass.ShowUsers();
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
