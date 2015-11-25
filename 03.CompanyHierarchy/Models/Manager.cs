namespace _03.CompanyHierarchy.Models
{
    using System.Collections.Generic;
    using Interfaces;

    public class Manager : Employee, IManager
    {
        private readonly IList<IEmployee> employees = new List<IEmployee>();

        public Manager(int id, string firstName, string lastName, decimal salary, Depratment depratment)
            : base(id, firstName, lastName, salary, depratment)
        {
        }

        public IList<IEmployee> Employees => this.employees;
    }
}