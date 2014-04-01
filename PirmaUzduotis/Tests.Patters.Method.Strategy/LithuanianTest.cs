using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Method.Strategy;
using App.Core;

namespace Tests.Patters.Method.Strategy
{
    [TestClass]
    public class LithuanianTest
    {
        [TestMethod]
        public void GetCorrectSalary()
        {
            Salary salary = new StrategySalary(new Lithuanian());
            salary.person = new Person("Aurimas", 1000, false, 0);
            Assert.AreEqual(845.5, salary.getSalary());
        }
        [TestMethod]
        public void GetCorrectSalaryWithTwoChildrenMarried()
        {
            Salary salary = new StrategySalary(new Lithuanian());
            salary.person = new Person("Aurimas", 1000, true, 2);
            Assert.AreEqual(875.5, salary.getSalary());
        }
        [TestMethod]
        public void GetCorrectSalaryWithTwoChildrenNotMarried()
        {
            Salary salary = new StrategySalary(new Lithuanian());
            salary.person = new Person("Aurimas", 1000, false, 2);
            Assert.AreEqual(905.5, salary.getSalary());
        }
        [TestMethod]
        public void GetSalaryThenMoreThanPNDWihtNoChilds()
        {
            Salary salary = new StrategySalary(new Lithuanian());
            salary.person = new Person("Aurimas", 2000, false, 0);
            Assert.AreEqual(1566.5, salary.getSalary());
        }
        [TestMethod]
        public void GetSalaryThenMoreThanPNDWihtTwoChildsNotMarried()
        {
            Salary salary = new StrategySalary(new Lithuanian());
            salary.person = new Person("Aurimas", 2000, false, 2);
            Assert.AreEqual(1626.5, salary.getSalary());
        }
        [TestMethod]
        public void GetSalaryThenMoreThanPNDWihtTwoChildsMarried()
        {
            Salary salary = new StrategySalary(new Lithuanian());
            salary.person = new Person("Aurimas", 2000, true, 2);
            Assert.AreEqual(1596.5, salary.getSalary());
        }
        [TestMethod]
        public void Get_Salary_From_Hand_To_Paper()
        {
            Salary salary = new StrategySalary(new Lithuanian());
            salary.person = new Person("Aurimas", 845.5, false, 0);
            Assert.AreEqual(1000, salary.getSalaryWithTaxes());
        }
    }
}
