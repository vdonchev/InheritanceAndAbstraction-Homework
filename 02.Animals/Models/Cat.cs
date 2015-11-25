namespace _02.Animals.Models
{
    public abstract class Cat : Animal
    {
        protected Cat(string name, int age, Gender gender) 
            : base(name, age, gender)
        {
        }

        public override string ProduceSound() => "Miaw, Miaw!";
    }
}