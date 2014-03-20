using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method.Strategy
{
    public class Norway : ISalaryCalculator
    {
        private string _countryCode = "no-NO";
        private double _nis = 7.8;
        private double _incomeTaxes = 28;
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
            double result = salary - this.CalculateTaxes(salary, married, childs);

            return result;
        }

        public double CalculateTaxes(double salary, bool married, int childs)
        {
            double result = (salary * this.incomeTaxes) / 100;
            result += (salary * this.nis) / 100;

            return result;
        }

        public double CalculateToHand(double salary, bool married, int childs)
        {
            throw new NotImplementedException();
        }
    }
}
