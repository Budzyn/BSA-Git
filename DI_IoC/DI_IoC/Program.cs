using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;


namespace DI_IoC
{
    class Program
    {
        private static readonly CheckAccess chk = new CheckAccess();
        static void Main(string[] args)
        {
            var factory = new Factory();
            var result = chk.Ping("http://www.dou.ua");

            // If 1 - write to console
            // If 2 - write to file
            // If 3 - both
            // If Esc - exit
            while (true)
            {
                var key = Console.ReadKey();
                if (ConsoleKey.Escape == key.Key)
                {
                    return;
                }
                var outputer = factory.Show(key.Key);
                outputer.WriteData(result);
            }
        }
    }
}
