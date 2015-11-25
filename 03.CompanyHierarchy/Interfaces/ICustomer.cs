namespace _03.CompanyHierarchy.Interfaces
{
    public interface ICustomer : IPerson
    {
        decimal TotalPurchaseAmount { get; }
    }
}