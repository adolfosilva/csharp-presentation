using System;
using System.Diagnostics;

namespace CSharpEvolution.CSharp2
{
    public static class NullCoalescingExamples
    {
        public static void Example1()
        {
            Nullable<bool> a = null;
            bool b = a ?? default(bool);
            Debug.Assert(b == false);
        }
    }
}
