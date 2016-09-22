using System;

namespace CSharpEvolution.CSharp4
{
    public static class DynamicExamples
    {
        private static void PrintString(string a)
        {
            Console.WriteLine(a);
        }

        public static void Example1()
        {
            dynamic a = "A simple string";
            PrintString(a);
            a = true; // a is assigned with a Boolean
            a = -45; // a is assigned with a Int32
            try
            {
                PrintString(a); // this compiles, but will fail at runtime
            }
            catch (Exception)
            {
                Console.WriteLine("Caught a 'Microsoft.CSharp.RuntimeBinder.RuntimeBinderException' at runtime.");
            }
            int b = a + 10;
        } 
    }
}
