namespace _03.CompanyHierarchy.Interfaces
{
    using System;

    public interface ISale
    {
        string ProductName { get; }

        DateTime Date { get; }

        decimal Price { get; }
    }
}