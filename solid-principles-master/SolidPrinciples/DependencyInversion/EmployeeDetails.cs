namespace SolidPrinciples.DependencyInversion
{
    public class EmployeeDetails
    {
        public int HoursWorked { get; set; }
        
        public int HourlyRate { get; set; }

        private IBase _IBase;

        //public float GetSalary()
        //{  
        //    var salaryCalculator = new SalaryCalculator();
        //    return salaryCalculator.CalculateSalary(HoursWorked, HourlyRate);
        //}

        public float GetSalary()
        {
            return _IBase.CalculateSalary(HoursWorked, HourlyRate);
        }
    }
}