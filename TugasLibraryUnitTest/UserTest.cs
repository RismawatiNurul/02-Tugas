using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TugasLibrary;
using NUnit.Framework;

namespace TugasLibraryUnitTest
{
    [TestFixture]
    public class UserTest
    {
        private User user;

        [SetUp]
        public void init()
        {
            user = new User();
        }

        [Test]
        public void TestValidUser()
        {
            var userName = "admin";
            var password = "admin";

            Assert.IsTrue(user.IsValidUser(userName, password));
        }
    }
}
