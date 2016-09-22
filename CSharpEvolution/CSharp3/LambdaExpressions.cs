using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpEvolution.CSharp3
{
    public static class LambdaExpressionsExamples
    {
        public static void Example1()
        {
            Func<int, int> fun1 = (int x) => { return x + 1; };
            Func<int, int> fun3 = (int x) => x + 1;
            Func<int, int> fun2 = x => x + 1;
            Console.WriteLine(fun2(5));

            Action printLie = () => Console.WriteLine("Benfica é o melhor clube");
            printLie(); // or printLie.Invoke()

            Action<bool> fun4 = b => Console.WriteLine(b ? "True" : "False");
            fun4.Invoke(false);
        }

        public static void MapExample()
        {
            Console.WriteLine("Map example");
            var numbers = new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            var result = Map(x => x*2, numbers); // In Haskell: map (\x -> x*2) [1..10]
            result.ToList().ForEach(r => Console.WriteLine(r));
        }

        private static IEnumerable<T> Map<T>(Func<T, T> func, IEnumerable<T> enumerable)
        {
            foreach (var item in enumerable)
            {
                yield return func(item);
            }
        }
    }
}
