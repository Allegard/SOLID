using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.InterfaceSegregation
{
    interface IContractEmployee
    {
        float HourlyRate { get; set; }

        float HoursInMonth { get; set; }

        float CalculateWorkedSalary();
    }
}
