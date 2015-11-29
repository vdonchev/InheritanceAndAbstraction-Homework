namespace _03.CompanyHierarchy.Interfaces
{
    using System.Collections.Generic;

    public interface IManager : IEmployee
    {
        IEnumerable<IEmployee> Employees { get; }

        void AddEmployee(IEmployee employee);

        void RemoveEmployee(IEmployee employee);
    }
}