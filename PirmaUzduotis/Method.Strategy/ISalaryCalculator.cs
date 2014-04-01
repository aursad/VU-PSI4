using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method.Strategy
{
    public interface ISalaryCalculator
    {
        /// <summary>
        /// Country code ex: lt-LT
        /// </summary>
        string countryCode { get; }
        /// <summary>
        /// social security contribution (NIS)
        /// </summary>
        double nis { get; }
        /// <summary>
        /// combined national and municipal income tax
        /// </summary>
        double incomeTaxes { get; }

        double CalculateWithTaxes(double salary, bool married, int childs);
        double CalculateTaxes(double salary, bool married, int childs);
        double CalculateToHand(double salary, bool married, int childs);

    }
}
