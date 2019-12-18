using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using CsvHelper;
using Datalink_TestApp.Services;

namespace Datalink_TestApp
{
    class Program
    {
        static void Main(string[] args)
        {  
            string path1 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "examples/users.csv");
            string path2 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "examples/new_users.csv");

            var matches = UserService.FindMatchesInCSVs(path1, path2);

            foreach (var match in matches)
            {
                Console.WriteLine(match.FirstName + ", " + match.LastName);
            }

        }
    }
}
