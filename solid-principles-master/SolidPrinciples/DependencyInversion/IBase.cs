using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.DependencyInversion
{
    interface IBase
    {
        float CalculateSalary(int hoursWorked, float hourlyRate);
    }
}
