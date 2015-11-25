namespace _02.Animals.Models
{
    public class Frog : Animal
    {
        public Frog(string name, int age, Gender gender) 
            : base(name, age, gender)
        {
        }

        public override string ProduceSound() => "Quack, Quack!";
    }
}