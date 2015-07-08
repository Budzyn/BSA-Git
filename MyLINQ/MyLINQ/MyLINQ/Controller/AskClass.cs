using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyLINQ.Models;

namespace MyLINQ.Controller
{
    class AskClass:Ask
    {
        public static void ShowAsk()
        {
            var listAsk = new List<Ask>
            {
                new Ask
                {
                    Category=".Net",
                    ListAsk="What is an abstract class?"
                },
                new Ask
                {
                    Category="JS",
                    ListAsk="What is a HTML5?"
                },
                new Ask
                {
                    Category="PHP",
                    ListAsk="What is a url?"
                },
                new Ask
                {
                    Category="DB",
                    ListAsk="What is a DataBase"
                },
                new Ask
                {
                    Category="OOP",
                    ListAsk="What is a Polymorphism?"
                },
                new Ask
                {
                    Category="English",
                    ListAsk="What is a noun?"
                },
            };

        }
    }
}
