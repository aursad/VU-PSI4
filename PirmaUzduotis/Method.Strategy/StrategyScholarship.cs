using App.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method.Strategy
{
    public class StrategyScholarship : Scholarship
    {
        protected ISalaryCalculator country;

        public StrategyScholarship(ISalaryCalculator country)
        {
            this.country = country;
        }

        public override double GetScholarship()
        {
            double result = this.person.Salary * this.person.Childs;
            return result;
        }
        public override double getTaxes()
        {
            double result = this.person.Salary * this.person.Childs;
            result = (result * this.taxes) + (result * this.nis);
            return result;
        }
        public override double getSalaryWithTaxes()
        {
            double result = this.country.CalculateToHand(person.Salary, person.Married, person.Childs);
            result += (result * this.taxes) + (result * this.nis);
            return result;
        }
    }
}
