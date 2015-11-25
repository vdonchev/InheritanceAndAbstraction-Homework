namespace _03.CompanyHierarchy.Models
{
    using Interfaces;

    public class Customer : Person, ICustomer
    {
        private decimal totalPurchaseAmount;

        public Customer(int id, string firstName, string lastName, decimal totalPurchaseAmount)
            : base(id, firstName, lastName)
        {
            this.TotalPurchaseAmount = totalPurchaseAmount;
        }

        public decimal TotalPurchaseAmount
        {
            get
            {
                return this.totalPurchaseAmount;
            }

            private set
            {
                Validators.Validations.IfIsNegative(value, "Person's total purchase amount");
                this.totalPurchaseAmount = value;
            }
        }

        public override string ToString() =>
            $"{base.ToString()}, total purchase amount: {this.TotalPurchaseAmount:C}";
    }
}