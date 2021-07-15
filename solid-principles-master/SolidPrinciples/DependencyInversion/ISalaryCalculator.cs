using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.DependencyInversion
{
    interface ISalaryCalculator
    {
        float CalculateSalary(int hoursWorked, float hourlyRate);
    }
}
