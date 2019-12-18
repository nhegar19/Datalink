using System;
using System.Collections.Generic;
using System.IO;
using Datalink_TestApp.classes;
using Datalink_TestApp.Services;
using NUnit.Framework;

namespace Datalink_TestApp.UnitTests
{
    [TestFixture]
    public class CSVHandlerTests
    {
        [Test]
        public void CSVToUserList_UsersCSV_Expect3Users()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "examples/users.csv");

            List<User> users = CSVHandler.CSVToUserList(path);

            Assert.AreEqual(3, users.Count);
        }

        [Test]
        public void CSVToUserList_NewUsersCSV_Expect2Users()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "examples/new_users.csv");

            List<User> users = CSVHandler.CSVToUserList(path);

            Assert.AreEqual(2, users.Count);
        }

        [Test]
        public void CSVToUserList_NewUsersCSV_ExpectCorrectEntryInPos0()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "examples/new_users.csv");

            List<User> users = CSVHandler.CSVToUserList(path);

            bool testPassed = false;

            if (users[0].FirstName == "Abraham" && users[0].LastName == "Lincoln" && users[0].Email == "honest1@live.com")
            {
                testPassed = true;
            }

            Assert.IsTrue(testPassed);
        }
    }
}
