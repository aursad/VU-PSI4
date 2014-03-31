using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PirmaUzduotis
{
    public abstract class Scholarship
    {
        public Person person;

        public abstract double GetScholarship();
        public abstract double getTaxes();
        public abstract double getSalaryWithTaxes();
    }
}
