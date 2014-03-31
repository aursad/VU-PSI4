using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Method.Strategy;
using PirmaUzduotis;

namespace Tests.Patters.Method.Strategy
{
    [TestClass]
    public class ScholarshipTest
    {
        [TestMethod]
        public void TestScholarshipObject()
        {
            Scholarship salary = new StrategyScholarship(new Lithuanian());
            salary.person = new Person("Aurimas", 325, false, 6);
            Assert.AreEqual(1950, salary.GetScholarship());
        }
        [TestMethod]
        public void Get_ScholarShip_for_one_month()
        {
            Scholarship salary = new StrategyScholarship(new Lithuanian());
            salary.person = new Person("Aurimas", 325, false, 1);
            Assert.AreEqual(325, salary.GetScholarship());
        }
        [TestMethod]
        public void Get_ScholarShip_for_one_month_taxes()
        {
            Scholarship salary = new StrategyScholarship(new Lithuanian());
            salary.person = new Person("Aurimas", 325, false, 6);
            Assert.AreEqual(419.55, salary.getTaxes());
        }
    }
}
