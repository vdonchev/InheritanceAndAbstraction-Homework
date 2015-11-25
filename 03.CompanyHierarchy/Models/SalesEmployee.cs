namespace _03.CompanyHierarchy.Models
{
    using System.Collections.Generic;
    using Interfaces;

    public class SalesEmployee : RegularEmployee, ISalesEmployee
    {
        private readonly IList<ISale> sales = new List<ISale>();

        public SalesEmployee(int id, string firstName, string lastName, decimal salary, Depratment depratment)
            : base(id, firstName, lastName, salary, depratment)
        {
        }

        public IList<ISale> Sales => this.sales;
    }
}