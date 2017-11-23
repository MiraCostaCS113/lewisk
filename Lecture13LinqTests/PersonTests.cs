using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lecture13Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture13Linq.Tests
{
    [TestClass()]
    public class PersonTests
    {
        [TestMethod()]
        public void ToStringTest()
        {
            Person person = new Person("K", "L", 1, 1, 1);
            Assert.AreEqual(person.ToString(), "K L, 1, 1 in., 1 lbs.");
        }
    }
}