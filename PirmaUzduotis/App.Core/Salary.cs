using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Core
{
    public abstract class Salary
    {
        public Person person;

        public abstract double getSalary();
        public abstract double getTaxes();
        public abstract double getSalaryWithTaxes();
    }
}
