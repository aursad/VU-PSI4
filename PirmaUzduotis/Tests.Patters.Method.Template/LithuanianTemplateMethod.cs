using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Method.Template;
using PirmaUzduotis;

namespace Tests.Patters.Method.Template
{
    [TestClass]
    public class LithuanianTemplateMethod
    {
        [TestMethod]
        public void Template_Method_Get_Lithuanian_Salary_Correct()
        {
            Salary salary = new TemplateLithuania();
            salary.person = new Person("Aurimas Sadauskas", 1000, false, 0);

            Assert.AreEqual(845.5, salary.getSalary());
        }
        [TestMethod]
        public void Template_Method_Get_Norway_Salary_Correct()
        {
            Salary salary = new TemplateNorway();
            salary.person = new Person("Aurimas", 20000, false, 0);
            Assert.AreEqual(12840, salary.getSalary());
        }
    }
}
