using System;
using System.Collections.Generic;
using static System.Math;

// using static
// ?. elvis
// auto initi. dictionary
// auto initi. auto-property
// string interpolation

namespace CSharpEvolution.CSharp6
{
    class Hello
    {
        public string Say { get; set;  } = "Hello!";

        public override string ToString() => $"{Say}: {2*Pow(PI,Say.Length)}";
    }

    public static class CSharp6Examples
    {
        public static void Example1()
        {
            var dict = new Dictionary<string, Hello>
            {
                ["England"] = new Hello(),
                ["Italy"] = new Hello {Say = "Ciao!"},
                ["France"] = new Hello {Say = "Sallut!"},
                ["Croatia"] = new Hello {Say = "Bog!"}
            };

            foreach (var kvp in dict)
            {
                Console.WriteLine($"'Hello!' in {kvp.Key} is '{kvp.Value}'");
            }
        }
    }
}
