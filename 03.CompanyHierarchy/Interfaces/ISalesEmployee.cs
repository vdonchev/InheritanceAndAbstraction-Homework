namespace _03.CompanyHierarchy.Interfaces
{
    using System.Collections.Generic;

    public interface ISalesEmployee : IRegularEmployee
    {
        IList<ISale> Sales { get; }
    }
}