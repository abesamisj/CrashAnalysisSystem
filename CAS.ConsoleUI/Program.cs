
using CAS.EntityModel.Models;
using System;
using System.Linq;

namespace CAS.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CrashHubContext db = new CrashHubContext();
            var userList = db.UserProfiles.ToList();

            foreach (var user in userList)
            {
                Console.WriteLine(user.userReportName);
                
            }
            Console.ReadLine();
        }
    }
}
