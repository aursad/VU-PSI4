using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PirmaUzduotis;

namespace Method.Strategy
{
    public class StrategySalary : Salary
    {
        protected ISalaryCalculator country;

        public StrategySalary(ISalaryCalculator country)
        {
            this.country = country;
        }

        public override double getSalary()
        {
            return this.country.CalculateWithTaxes(person.Salary, person.Married, person.Childs);
        }
        public override double getTaxes()
        {
            return this.country.CalculateTaxes(person.Salary, person.Married, person.Childs);
        }
        public override double getSalaryWithTaxes()
        {
            return this.country.CalculateToHand(person.Salary, person.Married, person.Childs);
        }
    }
}
