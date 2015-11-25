namespace _03.CompanyHierarchy.Interfaces
{
    using System.Collections.Generic;

    public interface IManager : IEmployee
    {
        IList<IEmployee> Employees { get; }
    }
}