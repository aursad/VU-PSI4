using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PirmaUzduotis;
using Method.Template;

namespace Tests.Patters.Method.Template
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ScholarShip()
        {
            Scholarship salary = new TemplateScholarshipLithuania();
            salary.person = new Person("Aurimas Sadauskas", 325, false, 6);

            Assert.AreEqual(1950, salary.GetScholarship());
        }
    }
}
