namespace _01.HumanStudentAndWorker.Models
{
    public abstract class Human
    {
        protected Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName { get; }

        public string LastName { get; }

        public override string ToString() =>
            $"{this.FirstName} {this.LastName}";
    }
}