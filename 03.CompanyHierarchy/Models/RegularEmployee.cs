namespace _03.CompanyHierarchy.Models
{
    public abstract class RegularEmployee : Employee
    {
        protected RegularEmployee(int id, string firstName, string lastName, decimal salary, Depratment depratment) 
            : base(id, firstName, lastName, salary, depratment)
        {
        }
    }
}