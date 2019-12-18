using System;
using System.IO;
using NUnit.Framework;

namespace Datalink_TestApp_UnitTests
{
    [TestFixture]
    public class TestSetup
    {
        [Test]
        public void UsersCSV_ExpectFileToExist()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "examples/new_users.csv");
            Assert.IsTrue(File.Exists(path));
        }

        [Test]
        public void NewUsersCSV_ExpectFileToExist()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "examples/users.csv");
            Assert.IsTrue(File.Exists(path));
        }
    }
}