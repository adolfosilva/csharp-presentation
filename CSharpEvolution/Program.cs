using System;
using System.Collections.Generic;
using CSharpEvolution.CSharp2;
using CSharpEvolution.CSharp3;
using CSharpEvolution.CSharp4;
using CSharpEvolution.CSharp6;

namespace CSharpEvolution
{
    class Program
    {
        static void Main()
        {
            RunAllExamples();
            Console.Write("Press any key to exit...");
            Console.ReadKey();
        }

        static void RunAllExamples()
        {
            List<Action> examples = new List<Action>()
            {
                #region C#2 Examples

                // Generics https://msdn.microsoft.com/en-us/library/ms379564%28v=vs.80%29.aspx
                GenericsExamples.IntStackExample,
                //GenericsExamples.ObjectStackExample,
                GenericsExamples.GenericStackExample,
                GenericsExamples.GenericMethodsExample,

                // Nullable types https://msdn.microsoft.com/en-us/library/1t3y8s4s.aspx
                NullableTypesExamples.Example1,

                // "??" aka Null-coalescing operator https://msdn.microsoft.com/en-us/library/ms173224.aspx
                NullCoalescingExamples.Example1,

                // Iterators https://msdn.microsoft.com/pt-pt/library/mt639331.aspx
                IteratorsExamples.Example1,

                #endregion

                #region C#3 Examples

                // Implicitly typed local variables https://msdn.microsoft.com/en-us/library/bb384061.aspx
                VarExamples.Example1,

                // Auto-implemented Properties https://msdn.microsoft.com/pt-pt/library/bb384054.aspx
                AutoImplementedPropertiesExamples.Example1,

                // Anonymous Types https://msdn.microsoft.com/en-us/library/bb397696.aspx
                AnonymousTypesExamples.Example1,

                // Object and Collection Initializers https://msdn.microsoft.com/en-us/library/bb384062.aspx
                ObjectAndCollectionInitializersExamples.Example1,

                // Extension methods https://msdn.microsoft.com/en-us/library/bb383977.aspx
                ExtensionMethodsExamples.PalindromeExample,
                ExtensionMethodsExamples.PrimesExample,

                // Lambda expressions https://msdn.microsoft.com/en-us/library/bb397687.aspx
                LambdaExpressionsExamples.Example1,
                LambdaExpressionsExamples.MapExample,

                // Query expressions https://msdn.microsoft.com/en-us/library/bb384065.aspx
                // https://msdn.microsoft.com/en-us/library/bb397933.aspx
                QueryExpressionsExamples.BasicExample,
                QueryExpressionsExamples.LessBasicExample,
                #endregion

                #region C#4 Examples
                // Named and Optional Arguments https://msdn.microsoft.com/en-us/library/dd264739.aspx
                NamedOptionalArgsExamples.Example1,

                // Dynamic https://msdn.microsoft.com/en-us/library/dd264741.aspx
                // TODO
                DynamicExamples.Example1,
                #endregion

                #region C#6 Examples
                CSharp6Examples.Example1,
                #endregion

            };
            
            foreach (Action example in examples)
            {
                example();
                Console.WriteLine();
            }
        }
    }
}
