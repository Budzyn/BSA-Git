using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyLINQ.Models;

namespace MyLINQ.Controller
{
    class TestClass:Test
    {
        public static void ShowTest()
        {
            var listTest = new List<Test>
            {
                new Test
                {
                    Name="Test for .Net students",
                    Category=new List<Ask>
                    {
                        new Ask {Category=".Net",ListAsk="What is a delegate"}
                    },
                    TimeMax=25,
                    MarkPass=35
                },
                new Test
                {
                    Name="Test for JS students",
                    Category=new List<Ask>
                    {
                        new Ask {Category="JS",ListAsk="What is a HTML5"}
                    },
                    TimeMax=20,
                    MarkPass=45
                }
            };
            var myTest = listTest.SelectMany(item => item.Category, (item, myList) => new { item, myList }).Where(p => p.myList.Category == ".Net").ToList();
            myTest.ForEach(item =>
                {
                    Console.WriteLine(item.item.Category);
                });
        }
    }
}
