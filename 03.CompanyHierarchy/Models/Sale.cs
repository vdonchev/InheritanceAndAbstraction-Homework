namespace _03.CompanyHierarchy.Models
{
    using System;
    using Interfaces;

    public class Sale : ISale
    {
        private string productName;
        private decimal price;

        public Sale(string productName, DateTime date, decimal price)
        {
            this.ProductName = productName;
            this.Date = date;
            this.Price = price;
        }

        public string ProductName
        {
            get
            {
                return this.productName;
            }

            private set
            {
                Validators.Validations.IfIsNull(value, "Product name");
                this.productName = value;
            }
        }

        public DateTime Date { get; }

        public decimal Price
        {
            get
            {
                return this.price;
            }

            private set 
            {
                Validators.Validations.IfIsNegative(value, "Product price");
                this.price = value;
            }
        }

        public override string ToString() =>
            $"{this.ProductName}, price: {this.Price:C}";
    }
}