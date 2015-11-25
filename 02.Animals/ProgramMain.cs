namespace _02.Animals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Models;

    public static class ProgramMain
    {
        public static void Main()
        {
            var animals = new List<Animal>
            {
                new Dog("Sharo", 15, Gender.Male),
                new Dog("Karaman", 8, Gender.Male),
                new Frog("Kermit", 3, Gender.Male),
                new Frog("Froggy", 7, Gender.Female),
                new Tomcat("Tom", 14),
                new Tomcat("Garfield", 18),
                new Kitten("Kitty", 6),
                new Kitten("Mariika", 2)
            };

            animals.ToList().ForEach(Console.WriteLine);
            Console.WriteLine();

            animals
                .GroupBy(animal => animal.GetType().Name)
                .Select(group => new
                {
                    AnimalName = group.Key,
                    AverageAge = group.Average(a => a.Age)
                })
                .OrderByDescending(group => group.AverageAge)
                .ToList()
                .ForEach(group => Console.WriteLine($"{group.AnimalName}'s average age is: {group.AverageAge}"));
        }
    }
}
