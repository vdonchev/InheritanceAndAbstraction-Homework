namespace _01.HumanStudentAndWorker.Models
{
    public class Worker : Human
    {
        private const int WeeklyWorkDays = 5;

        public Worker(string firstName, string lastName, decimal weekSalary, double workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        private decimal WeekSalary { get; }

        private double WorkHoursPerDay { get; }

        public decimal MoneyPerHour()
        {
            return this.WeekSalary / (decimal)(this.WorkHoursPerDay * WeeklyWorkDays);
        }

        public override string ToString() =>
            $"{base.ToString()} ({this.MoneyPerHour():C}/h)";
    }
}