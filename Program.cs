using ConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MainContext context = new MainContext();

            foreach (var it in DataManager.userinroles)
                context.UserInRoles.Add(it);

            context.SaveChanges();

            //foreach(var it in context.Users)
            //    Console.WriteLine($"{it.Email} - {it.UserName}");
        }
    }
}
