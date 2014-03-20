using PirmaUzduotis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method.Strategy
{
    public class Lithuanian : ISalaryCalculator
    {
        private string _countryCode = "lt-LT";
        private double _nis = 6;
        private double _incomeTaxes = 15;
        //Other
        private int _pensijuDraudimas = 3;


        public string countryCode
        {
            get { return _countryCode; }
        }

        public double nis
        {
            get { return _nis; }
        }

        public double incomeTaxes
        {
            get { return _incomeTaxes; }
        }

        public double CalculateWithTaxes(double salary, bool married, int childs)
        {
            return (salary - CalculateTaxes(salary,married,childs));
        }

        public double CalculateTaxes(double salary, bool married, int childs)
        {
            double salaryCount = salary - NPD(salary) - PNDP(married, childs);
            double result = (salaryCount * incomeTaxes) / 100;
            result += (salary * nis) / 100;
            result += (salary *_pensijuDraudimas) / 100;

            return result;
        }

        public double CalculateToHand(double salary, bool married, int childs)
        {
            return 0.00;
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
