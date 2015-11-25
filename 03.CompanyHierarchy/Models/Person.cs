namespace _03.CompanyHierarchy.Models
{
    using Interfaces;

    public abstract class Person : IPerson
    {
        private int id;
        private string firstName;
        private string lastName;

        protected Person(int id, string firstName, string lastName)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.Lastname = lastName;
        }

        public int Id
        {
            get
            {
                return this.id;
            }

            private set
            {
                Validators.Validations.IfIsNegative(value, "Person's id");
                this.id = value;
            }
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            private set
            {
                Validators.Validations.IfIsNull(value, "Person's first name");
                this.firstName = value;
            }
        }

        public string Lastname
        {
            get
            {
                return this.lastName;
            }

            private set
            {
                Validators.Validations.IfIsNull(value, "Person's last name");
                this.lastName = value;
            }
        }

        public override string ToString() =>
            $"[{this.Id.ToString().PadLeft(5, '0')}] ({this.GetType().Name}) {this.FirstName} {this.lastName}";
    }
}