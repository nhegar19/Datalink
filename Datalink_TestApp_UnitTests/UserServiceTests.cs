using System;
using System.Collections.Generic;
using System.IO;
using Datalink_TestApp.classes;
using Datalink_TestApp.Services;
using NUnit.Framework;

namespace Datalink_TestApp.UnitTests
{
    [TestFixture]
    public class UserServiceTests
    {
        [Test]
        public void CompareCSVs_UserVsNewUsers_Expect1Match()
        {
            string path1 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "examples/users.csv");
            string path2 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "examples/new_users.csv");

            List<User> users = UserService.FindMatchesInCSVs(path1, path2);

            Assert.AreEqual(1, users.Count);
        }

        [Test]
        public void CompareCSVs_UserVsNewUsers_ExpectMatchAbrahamLincoln()
        {
            string path1 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "examples/users.csv");
            string path2 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "examples/new_users.csv");

            List<User> users = UserService.FindMatchesInCSVs(path1, path2);

            bool testPassed = false;

            if(users[0].FirstName =="Abraham" && users[0].LastName=="Lincoln")
            {
                testPassed = true;
            }

            Assert.IsTrue(testPassed);
        }

        
    }
}
