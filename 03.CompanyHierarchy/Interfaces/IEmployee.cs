namespace _03.CompanyHierarchy.Interfaces
{
    using Models;

    public interface IEmployee : IPerson
    {
        decimal Salary { get; }

        Depratment Depratment { get; }
    }
}