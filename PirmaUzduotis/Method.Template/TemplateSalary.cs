using PirmaUzduotis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method.Template
{
    public abstract class TemplateSalary : Salary
    {
        protected abstract double doGetTaxes(double salary, bool married, int childs);

        protected abstract double doGetBaseSalary(double salary, bool married, int childs);

        public sealed override double getSalary()
        {
            return this.doGetBaseSalary(this.person.Salary, this.person.Married, this.person.Childs);
        }
        
        public double getTaxes()
        {
            return this.doGetTaxes(this.person.Salary, this.person.Married, this.person.Childs);
        }
    }
}
