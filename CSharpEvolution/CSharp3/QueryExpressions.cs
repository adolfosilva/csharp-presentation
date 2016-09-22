using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpEvolution.CSharp3
{
    public static class QueryExpressionsExamples
    {
        public static void BasicExample()
        {
            var numbers = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            var evens = from number in numbers
                        where number % 2 == 0
                        select number;

            // var evens = numbers.Where(number => number % 2 == 0);

            foreach (var n in evens)
            {
                Console.WriteLine(n);
            }
        }

        public static void LessBasicExample()
        {
            var twinPeaks = new List<Person>()
            {
                new Person {Name = "Special Agent Dale Cooper", Age = 32},
                new Person {Name = "Gordon Cole", Age = 45},
                new Person {Name = "Maddy Ferguson", Age = 20},
                new Person {Name = "Sarah Palmer", Age = 20},
            };

            IEnumerable<string> names = from p in twinPeaks
                let name = p.Name
                where name.Contains("a")
                orderby name.Length
                select name.ToUpper();

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

        }
    }
}
