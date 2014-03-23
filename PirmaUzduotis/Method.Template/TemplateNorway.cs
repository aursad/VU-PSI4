using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method.Template
{
    public class TemplateNorway : TemplateSalary
    {
        private string _countryCode = "no-NO";
        private double _nis = 7.8;
        private double _incomeTaxes = 28;

        protected override double doGetTaxes(double salary, bool married, int childs)
        {
            double result = (salary * this._incomeTaxes) / 100;
            result += (salary * this._nis) / 100;

            return result;
        }

        protected override double doGetBaseSalary(double salary, bool married, int childs)
        {
            double result = salary - this.doGetTaxes(salary, married, childs);

            return result;
        }
    }
}
