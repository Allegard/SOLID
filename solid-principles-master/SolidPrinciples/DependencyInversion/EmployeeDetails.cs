namespace SolidPrinciples.DependencyInversion
{
    public class EmployeeDetails
    {
        public int HoursWorked { get; set; }
        
        public int HourlyRate { get; set; }

        private ISalaryCalculator _ISalaryCalculator;

        public EmployeeDetails()
        {
            _ISalaryCalculator = SalaryCalculatorFactory.GetSalaryCalculatorObj();
        }

        //public float GetSalary()
        //{  
        //    var salaryCalculator = new SalaryCalculator();
        //    return salaryCalculator.CalculateSalary(HoursWorked, HourlyRate);
        //}

        public float GetSalary()
        {
            return _ISalaryCalculator.CalculateSalary(HoursWorked, HourlyRate);
        }
    }
}