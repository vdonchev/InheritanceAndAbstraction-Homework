namespace _03.CompanyHierarchy.Models
{
    using System.Collections.Generic;
    using Interfaces;

    public class Developer : RegularEmployee, IDeveloper
    {
        private readonly IList<IProject> projects = new List<IProject>();

        public Developer(int id, string firstName, string lastName, decimal salary, Depratment depratment) 
            : base(id, firstName, lastName, salary, depratment)
        {
        }

        public IList<IProject> Projects => this.projects;
    }
}