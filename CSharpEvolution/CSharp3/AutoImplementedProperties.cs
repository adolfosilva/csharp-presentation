using System;

namespace CSharpEvolution.CSharp3
{
    class Persona
    {
        public string Name { get; set; }
        public int Age { get; }
        private readonly DateTime _birthday;

        public Persona(string name, DateTime birthday)
        {
            Name = name;
            _birthday = birthday;
            Age = CalculateAge(_birthday);
        }

        private static int CalculateAge(DateTime birthday)
        {
            DateTime now = DateTime.Today;
            int age = now.Year - birthday.Year;
            if (now < birthday.AddYears(age)) age--;
            return age;
        }
    }

    public static class AutoImplementedPropertiesExamples
    {
        public static void Example1()
        {
            var person = new Persona("Ivan Vazov", new DateTime(1850, 07, 09));
            // person.Name = "Johnny Valium"; // legal
            // person.Age = 10; // illegal
            Console.WriteLine("{0} is {1} years old today.", person.Name, person.Age);
        }
    }
}
