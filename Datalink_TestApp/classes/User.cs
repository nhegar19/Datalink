using System;
using CsvHelper.Configuration.Attributes;

namespace Datalink_TestApp.classes
{
    public class User
    {
        [Name("FirstName")]
        public string FirstName { get; set; }

        [Name("LastName")]
        public string LastName { get; set; }

        [Name("Email")]
        public string Email { get; set; }
    }
}
