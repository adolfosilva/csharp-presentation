using System.Collections.Generic;

namespace CSharpEvolution.CSharp3
{
    public static class VarExamples
    {
        public static void Example1()
        {
            // simple types
            var i = 6050; // 'i' is compiled as an int
            var b = true; // 'b' is compiled as a boolean
            var s = "Bob Harper"; // 'c' is compiled as a string
            // more complex types
            var a = new Dictionary<string, string>();
            var ia = new[] {1, 2, 3, 4, 5}; // 'ia' is compiled as int[]
        }
    }
}
