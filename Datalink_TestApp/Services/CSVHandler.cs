using System.Collections.Generic;
using System.IO;
using System.Linq;
using CsvHelper;
using Datalink_TestApp.classes;

namespace Datalink_TestApp.Services
{
    public static class CSVHandler
    {
        public static List<User> CSVToUserList(string path)
        {
            List<User> userRecords = new List<User>();

            using (var reader = new StreamReader(path))
            using (var csv = new CsvReader(reader))
            {
                userRecords = csv.GetRecords<User>().ToList();
            }

            return userRecords;
        }

    }
}
