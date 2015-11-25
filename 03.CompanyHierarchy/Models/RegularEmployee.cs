namespace _03.CompanyHierarchy.Models
{
    using Interfaces;

    public abstract class RegularEmployee : Employee, IRegularEmployee
    {
        protected RegularEmployee(int id, string firstName, string lastName, decimal salary, Depratment depratment) 
            : base(id, firstName, lastName, salary, depratment)
        {
        }
    }
}