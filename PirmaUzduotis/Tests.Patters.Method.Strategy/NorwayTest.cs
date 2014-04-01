using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using App.Core;
using Method.Strategy;

namespace Tests.Patters.Method.Strategy
{
    [TestClass]
    public class NorwayTest
    {
        [TestMethod]
        public void NorwayGetSalaryCorrect()
        {
            Salary salary = new StrategySalary(new Norway());
            salary.person = new Person("Aurimas", 20000, false, 0);
            Assert.AreEqual(12840, salary.getSalary());
        }
        [TestMethod]
        public void NorwayGetSalaryCorrectToHand()
        {
            Salary salary = new StrategySalary(new Norway());
            salary.person = new Person("Aurimas", 12840, false, 0);
            Assert.AreEqual(20000, salary.getSalaryWithTaxes());
        }
    }
}
