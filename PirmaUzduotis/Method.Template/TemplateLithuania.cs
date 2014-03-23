using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method.Template
{
    public class TemplateLithuania : TemplateSalary
    {
        private string _countryCode = "lt-LT";
        private double _nis = 6;
        private double _incomeTaxes = 15;
        //Other
        private int _pensijuDraudimas = 3;

        protected override double doGetBaseSalary(double salary, bool married, int childs)
        {
            return (salary - this.doGetTaxes(salary, married, childs));
        }

        protected override double doGetTaxes(double salary, bool married, int childs)
        {
            double salaryCount = salary - NPD(salary) - PNDP(married, childs);
            double result = (salaryCount * _incomeTaxes) / 100;
            result += (salary * _nis) / 100;
            result += (salary * _pensijuDraudimas) / 100;

            return result;
        }

        protected override double doGetSalaryWithTaxes(double salary, bool married, int childs)
        {
            return Math.Round(salary * 1.182732111);
        }

        private double NPD(double salary)
        {
            if (salary < 1000)
            {
                return (double)570;
            }
            else
            {
                return (double)(570 - 0.26 * (salary - 1000));
            }
        }
        private double PNDP(bool married, int childs)
        {
            double result = childs * 100;
            return married == false ? result * 2 : result;
        }
    }
}
