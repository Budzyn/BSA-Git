using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyLINQ.Models;

namespace MyLINQ.Controller
{
    class UsersClass:Users
    {
        public static void ShowUsers()
        {
            var listUsers = new List<Users>
            {
                new Users
                {
                    Name="Yaroslav",
                    Email="black_witcher@ukr.net",
                    Age=26,
                    City="Lviv",
                    University="LDFA",
                    Category=".NET"
                },
                new Users
                {
                    Name="Taras",
                    Email="Taras@gmail.com",
                    Age=23,
                    City="Kiev",
                    University="Politech",
                    Category=".NET"
                },
                new Users
                {
                    Name="Olga",
                    Email="Olga@gmail.com",
                    Age=21,
                    City="Kiev",
                    University="Politech",
                    Category="JScript"
                },
                new Users
                {
                    Name="Dima",
                    Email="Dima@gmail.com",
                    Age=23,
                    City="lviv",
                    University="Politech",
                    Category="JScript"
                },
            };
            //var result = (from Users in listUsers where Users.City == "Kiev" || Users.City == "lviv" select Users.City);
            //foreach (var users in result)
            //{
            //    Console.WriteLine(users);
            //}


            var result = from Users in listUsers
                         group Users by Users.City;
            foreach (var userGroup in result)
            {
                Console.WriteLine(userGroup.Key);
                foreach (Users customer in userGroup)
                {
                    Console.WriteLine("    {0}", customer.Name);
                }
            }
        }
    }
}
