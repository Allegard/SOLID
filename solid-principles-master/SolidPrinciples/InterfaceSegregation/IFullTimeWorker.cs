using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.InterfaceSegregation
{
    interface IFullTimeWorker
    {
        float MonthlySalary { get; set; }

        float OtherBenefits { get; set; }

        float CalculateNetSalary();
    }
}
