using System;

namespace CSharpEvolution.CSharp3
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public static class ObjectAndCollectionInitializersExamples
    {
        public static void Example1()
        {
            var person = new Person {Name = "John Doe", Age = 25};
            Console.WriteLine(person.Name + " " + person.Age);
        }
    }
}
