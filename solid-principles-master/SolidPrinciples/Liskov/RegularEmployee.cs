using System;

namespace SolidPrinciples.Liskov
{
    public class RegularEmployee : EmployeeBase
    {
        public override string GetProjectDetails(int employeeId)
        {
            return base.GetProjectDetails(employeeId);
        }

        public override string GetEmployeeDetails(int employeeId)
        {
            return base.GetEmployeeDetails(employeeId);
        }
    }
}