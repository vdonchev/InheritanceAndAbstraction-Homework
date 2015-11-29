namespace _03.CompanyHierarchy.Models
{
    using System;
    using System.Collections.Generic;
    using Interfaces;

    public class Manager : Employee, IManager
    {
        private readonly IList<IEmployee> employees = new List<IEmployee>();

        public Manager(int id, string firstName, string lastName, decimal salary, Depratment depratment)
            : base(id, firstName, lastName, salary, depratment)
        {
        }

        public IEnumerable<IEmployee> Employees => this.employees;

        public void AddEmployee(IEmployee employee)
        {
            if (employee.Depratment != this.Depratment)
            {
                throw new InvalidOperationException(CompanyConstants.WrongEmployee);
            }

            this.employees.Add(employee);
        }

        public void RemoveEmployee(IEmployee employee)
        {
            this.employees.Remove(employee);
        }
    }
}