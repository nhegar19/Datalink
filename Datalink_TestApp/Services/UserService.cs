using System.Linq;
using System.Collections.Generic;
using Datalink_TestApp.classes;

namespace Datalink_TestApp.Services
{
    public static class UserService
    {
        public static List<User> FindMatchesInCSVs(string csvPath1, string csvPath2)
        {
            List<User> allMatches = new List<User>();
            List<User> storedRecords = CSVHandler.CSVToUserList(csvPath1);
            List<User> newRecords = CSVHandler.CSVToUserList(csvPath2);


            foreach (var rec in storedRecords)
            {
                var matches = newRecords.Where(nr => rec.FirstName == nr.FirstName && rec.LastName == nr.LastName);

                if(matches != null)
                {
                    allMatches.AddRange(matches.ToList());
                }
            }

            return allMatches;
        }
    }
}
