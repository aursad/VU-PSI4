using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using App.Core;

namespace ProgramTests
{
    [TestClass]
    public class PersonTests
    {
        [TestMethod]
        public void CreatePerson()
        {
            Person person = new Person("Aurimas", 1000, false, 0);
            Assert.AreEqual("Aurimas", person.Name);
            Assert.AreEqual(1000, person.Salary);
            Assert.AreEqual(false, person.Married);
            Assert.AreEqual(0, person.Childs);
        }
        [TestMethod]
        public void ChangePersonSalary()
        {
            Person person = new Person("Aurimas", 1000, false, 0);
            Assert.AreEqual(1000, person.Salary);
            person.Salary = 2000;
            Assert.AreEqual(2000, person.Salary);
        }
    }
}
