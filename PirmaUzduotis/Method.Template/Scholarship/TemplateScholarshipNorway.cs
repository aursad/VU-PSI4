using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method.Template
{
    public class TemplateScholarshipNorway : TemplateScholarship
    {
        private string _countryCode = "no-NO";
        private double _nis = 0;
        private double _incomeTaxes = 0;

        protected override double doGetBaseSalary(double salary, bool married, int childs)
        {
            return (salary - this.doGetTaxes(salary, married, childs));
        }

        protected override double doGetTaxes(double salary, bool married, int childs)
        {
            double salaryCount = salary;
            double result = (salaryCount * _incomeTaxes) / 100;
            result += (salary * _nis) / 100;

            return result;
        }

        protected override double doGetSalaryWithTaxes(double salary, bool married, int childs)
        {
            return Math.Round(salary * 1.5576324);
        }
    }
}
