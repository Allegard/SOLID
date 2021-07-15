namespace SolidPrinciples.DependencyInversion
{
    public class SalaryCalculator : IBase
    {
        //public float CalculateSalary(int hoursWorked, float hourlyRate) => hoursWorked * hourlyRate;

        public float CalculateSalary(int hoursWorked, float hourlyRate)
        {
            return hoursWorked * hourlyRate;
        }
    }
}