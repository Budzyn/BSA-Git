using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyLINQ.Models;

namespace MyLINQ.Controller
{
    class DoTestClass : DoTest
    {
        public static void ShowDoTest()
        {
            var listDoTest = new List<DoTest>
            {
                new DoTest
                {
                    TestName="Test for .Net students",
                    User="Yaroslav",
                    Result=20,
                    TimeResult=50
                },
                new DoTest
                {
                    TestName="Test for .Net students",
                    User="Dima",
                    Result=35,
                    TimeResult=22
                },
                new DoTest
                {
                    TestName="Test for .Net students",
                    User="Oleg",
                    Result=15,
                    TimeResult=22
                },
                new DoTest
                {
                    TestName="Test for JS students",
                    User="Oksana",
                    Result=35,
                    TimeResult=25
                },
                new DoTest
                {
                    TestName="Test for JS students",
                    User="Yaroslav",
                    Result=5,
                    TimeResult=20
                },
            };
            Console.WriteLine("List of people who have passed the tests");
            var listTest = (from DoTest in listDoTest where DoTest.Result >= 20 select DoTest.User);
            foreach (var test in listTest)
            {
                Console.WriteLine(test);
            }
            Console.WriteLine("Members list passed tests and invested in time");
            var listTest2 = (from DoTest in listDoTest where DoTest.Result >= 20 && DoTest.TimeResult <= 25 select DoTest.User);
            foreach (var test2 in listTest2)
            {
                Console.WriteLine(test2);
            }
            Console.WriteLine("Members list passed tests and is not invested in time");
            var listTest3 = (from DoTest in listDoTest where DoTest.Result >= 20 && DoTest.TimeResult >= 25 select DoTest.User);
            foreach (var test3 in listTest3)
            {
                Console.WriteLine(test3);
            }


            var listMark = from DoTest in listDoTest.AsEnumerable()
                           group DoTest by DoTest.Result into g
                           select new
                               {
                                   res = g.Key,
                                   average = g.Average(DoTest => DoTest.Result)
                               };
            foreach (var mark in listMark)
            {
                Console.WriteLine("Mark={0}", mark.res);
            }
        }
    }
}
