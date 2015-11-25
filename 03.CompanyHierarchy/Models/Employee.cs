namespace _03.CompanyHierarchy.Models
{
    using Interfaces;

    public abstract class Employee : Person, IEmployee
    {
        private decimal salary;

        protected Employee(int id, string firstName, string lastName, decimal salary, Depratment depratment)
            : base(id, firstName, lastName)
        {
            this.Salary = salary;
            this.Depratment = depratment;
        }

        public Depratment Depratment { get; }

        public decimal Salary
        {
            get
            {
                return this.salary;
            }

            private set
            {
                Validators.Validations.IfIsNegative(value, "Employee's salary");
                this.salary = value;
            }
        }

        public override string ToString() =>
            $"{base.ToString()}, Department: {this.Depratment}, Salary: {this.Salary:C}";
    }
}