namespace _02.Animals.Models
{
    using Interfaces;

    public abstract class Animal : ISoundProducible
    {
        protected Animal(string name, int age, Gender gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public int Age { get; private set; }

        private string Name { get; }

        private Gender Gender { get; set; }

        public abstract string ProduceSound();

        public override string ToString() =>
            $"I'm {this.Name} the {this.GetType().Name}, {this.ProduceSound()}";
    }
}