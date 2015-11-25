namespace _01.HumanStudentAndWorker
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Models;

    public static class ProgramMain
    {
        public static void Main()
        {
                var students = new List<Student>()
                {
                    new Student("George", "Perry", "BG1994"),
                    new Student("Phillip", "Hart", "BG1116"),
                    new Student("Barbara", "Bradley", "BG1375"),
                    new Student("Charles", "Banks", "BG1775"),
                    new Student("Jesse", "Coleman", "BG1373"),
                    new Student("Joe", "West", "BG1473"),
                    new Student("Sarah", "Richardson", "BG1413"),
                    new Student("Carl", "Turner", "BG1415"),
                    new Student("Samuel", "Banks", "BG1419"),
                    new Student("Ralph", "Dixon", "BG1535"),
                };
                var wordkers = new List<Worker>()
                {
                    new Worker("Jonathan", "Gibson", 1596.33M, 8),
                    new Worker("Brian", "Duncan", 196.3M, 8),
                    new Worker("Ernest", "Andrews", 1996.28M, 6),
                    new Worker("Kenneth", "Cook", 9696.33M, 2),
                    new Worker("Emily", "Ford", 1886.33M, 16),
                    new Worker("Katherine", "Thomas", 1336M, 12),
                    new Worker("Lori", "Jones", .33M, 16),
                    new Worker("Linda", "Murphy", 6.80M, 2),
                    new Worker("Carl", "Johnson", 15.33M, 6),
                    new Worker("Susan", "Jacobs", 1.33M, 10),
                };

                var sortedStudents = students.OrderBy(s => s.FacultyNumber);
                var sortedWorkers = wordkers.OrderBy(w => w.MoneyPerHour());
                var humans = new List<Human>().Concat(students).Concat(wordkers);
                var allOrdered = humans.OrderBy(h => h.FirstName).ThenBy(h => h.LastName);
            
                PrintCollection(sortedStudents);
                PrintCollection(sortedWorkers);
                PrintCollection(allOrdered);
            }

        private static void PrintCollection<T>(IEnumerable<T> community)
        {
            foreach (var person in community)
            {
                Console.WriteLine(person);
            }
        }
    }
}
