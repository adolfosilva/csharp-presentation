using System;

namespace CSharpEvolution.CSharp3
{
    public static class AnonymousTypesExamples
    {
        public static void Example1()
        {
            var person = new {Name = "Joahnna Katter", Age = 56};
            Console.WriteLine(person);

            var anonArray = new[]
            {
                new { name = "apple", diam = 4 },
                new { name = "grape", diam = 1 }
            };
        }
    }
}
