namespace _03.CompanyHierarchy
{
    using System;
    using System.Collections.Generic;
    using Models;

    public static class ProgramMain
    {
        public static void Main()
        {
            var employees = new List<Employee>
            {
                new Developer(69, "Maëly", "Howell", 998.88m, Depratment.Production),
                new SalesEmployee(159, "Matthew", "Hart", 898.88m, Depratment.Sales),
                new SalesEmployee(85, "Alice", "Nguyen", 798.88m, Depratment.Sales),
                new Manager(1, "Beverly", "Jenkins", 698.88m, Depratment.Accounting),
                new Manager(333, "Steven", "Rose", 1998.88m, Depratment.Marketing),
                new Developer(5698, "Norma", "Lynch", 2098.88m, Depratment.Production),
                new SalesEmployee(197, "Heather", "Simpson", 80.88m, Depratment.Sales),
                new SalesEmployee(179, "Samuel", "Price", 80.88m, Depratment.Sales),
                new Manager(6, "Kathy", "Lawson", 9908.88m, Depratment.Marketing),
                new Developer(9, "Janet", "Willis", 198.88m, Depratment.Production),
                new Manager(123, "Kelly", "Gutierrez", 398.88m, Depratment.Accounting),
            };

            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }

            var man = new Manager(5, "Videlin", "Donchev", 1999, Depratment.Accounting);
            man.AddEmployee(new Developer(5, "Ivo", "Tokiev", 55, Depratment.Accounting));
        }
    }
}
