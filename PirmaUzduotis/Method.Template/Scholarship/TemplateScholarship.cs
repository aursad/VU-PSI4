using App.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method.Template
{
    public abstract class TemplateScholarship : Scholarship
    {
        protected abstract double doGetTaxes(double salary, bool married, int childs);
        protected abstract double doGetBaseSalary(double salary, bool married, int childs);
        protected abstract double doGetSalaryWithTaxes(double salary, bool married, int childs);

        public sealed override double GetScholarship()
        {
            return (this.person.Salary * this.person.Childs);
        }

        public sealed override double getTaxes()
        {
            double result = this.person.Salary * this.person.Childs;
            result = (result * this.taxes) + (result * this.nis);
            return result;
        }

        public sealed override double getSalaryWithTaxes()
        {
            double result = this.person.Salary * this.person.Childs;
            result += (result * this.taxes) + (result * this.nis);
            return result;
        }
    }
}
