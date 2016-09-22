using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharpEvolution.CSharp2
{
    class Student
    {
        private readonly string _name;

        public Student(string name)
        {
            _name = name;
        }

        public override string ToString()
        {
            return string.Format("Name: {0}", _name);
        }
    }
    class Students: IEnumerable<Student>
    {
        private readonly List<Student> _students;

        public Students()
        {
            _students = new List<Student>(10);
        }

        public void Add(Student student)
        {
            _students.Add(student);
        }

        public IEnumerator<Student> GetEnumerator()
        {
            for (int i = 0; i < _students.Count; i++)
            {
                yield return _students[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public static class IteratorsExamples
    {
        public static void Example1()
        {
            Students students = new Students();
            students.Add(new Student("Fernando Pessoa"));
            students.Add(new Student("Florbela Espanca"));
            students.Add(new Student("Leo Tolstoi"));

            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }
        }
    }
}
