using PirmaUzduotis;
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
            return (this.person.Salary*this.person.Childs);
        }
        public override double getTaxes()
        {
            return this.country.CalculateTaxes(person.Salary*person.Childs, false, 0);
        }
        public override double getSalaryWithTaxes()
        {
            return this.country.CalculateToHand(person.Salary, person.Married, person.Childs);
        }
    }
}
