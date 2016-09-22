using System;

namespace CSharpEvolution.CSharp2
{
    public static class NullableTypes
    {
        public static void ShowValue(int? a)
        {
            if (a.HasValue)
            {
                Console.WriteLine("Argument's value is: " + a);
            }
            else
            {
                Console.WriteLine("Default value: " + a.GetValueOrDefault());
            }
        }
    }

    public static class NullableTypesExamples
    {
        public static void Example1()
        {
            int? a = null; // T? is just syntactic sugar for Nullable<T>
            NullableTypes.ShowValue(a);
            a = 4;
            NullableTypes.ShowValue(a);
        }
    }
}
