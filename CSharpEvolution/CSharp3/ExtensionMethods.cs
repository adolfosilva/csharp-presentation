using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpEvolution.CSharp3
{
    public static class ExtensionMethodsExamples
    {
        // A palindrome is a word, phrase, number, or other sequence of characters which reads the same backward or forward.
        public static bool IsPalindrome(this string str)
        {
            return str.SequenceEqual(str.Reverse());
        }

        // https://en.wikipedia.org/wiki/AKS_primality_test
        private static bool IsPrime(this int n)
        {
            if (n == 2) return true;
            if (n == 3) return true;
            if (n % 2 == 0) return false;
            if (n % 3 == 0) return false;

            var i = 5;
            var w = 2;

            while (i * i <= n)
            {
                if (n%i == 0)
                {
                    return false;
                }

                i += w;
                w = 6 - w;
            }

            return true;
        }
        public static int[] Primes(this int[] numbers)
        {
            var primes = new List<int>();
            foreach (var number in numbers)
            {
                if (number.IsPrime()) primes.Add(number);
            }
            return primes.ToArray();
        }

        public static void PalindromeExample()
        {
            var s = "lover";
            Console.WriteLine("\"{0}\" is palindrome? {1}", s, s.IsPalindrome());
            s = "detartrated";
            Console.WriteLine("\"{0}\" is palindrome? {1}", s, s.IsPalindrome());
        }

        public static void PrimesExample()
        {
            var xs = new int[] { 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89 };

            foreach (var prime in xs.Primes())
            {
                Console.WriteLine("Prime: " + prime);
            }
        }
    }
}
