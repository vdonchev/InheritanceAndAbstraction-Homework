namespace _03.CompanyHierarchy.Interfaces
{
    using System.Collections.Generic;

    public interface IDeveloper : IRegularEmployee
    {
        IList<IProject> Projects { get; }
    }
}