using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Core
{
    public abstract class Scholarship
    {
        public Person person;
        public double nis = 0;
        public double taxes = 0.1;

        public abstract double GetScholarship();
        public abstract double getTaxes();
        public abstract double getSalaryWithTaxes();
    }
}
