using System;
using System.Diagnostics;

namespace CSharpEvolution.CSharp2
{
    class IntStack
    {
        private int[] _items;
        private int _count;

        public IntStack()
        {
            _items = new int[100];
            _count = 0;
        }

        public void Push(int item)
        {
            _items[_count++] = item;
        }
        public int Pop()
        {
            return _items[--_count];
        }
    }
    class BoolStack
    {
        private bool[] _items;
        private int _count;

        public BoolStack()
        {
            _items = new bool[100];
            _count = 0;
        }

        public void Push(bool item)
        {
            _items[_count++] = item;
        }
        public bool Pop()
        {
            return _items[--_count];
        }
    }

    class ObjectStack
    {
        private object[] _items;
        private int _count;

        public ObjectStack()
        {
            _count = 0;
            _items = new object[100];
        }
        public void Push(object item)
        {
            _items[_count++] = item;
        }
        public object Pop()
        {
            return _items[--_count];
        }
    }

    public class Stack<T>
    {
        private T[] _items;
        private int _count;

        public Stack()
        {
            _count = 0;
            _items = new T[100];
        }

        public void Push(T item)
        {
            _items[_count++] = item;
        }

        public T Pop()
        {
            return _items[--_count];
        }
    }

    static class GenericMethods
    {
        public static void Swap<T>(ref T a, ref T b)
        {
            T tmp = a;
            a = b;
            b = tmp;
        }
    }

    public static class GenericsExamples
    {
        public static void IntStackExample()
        {
            IntStack s = new IntStack();
            s.Push(2);
            s.Push(5);
            s.Push(10);
            Debug.Assert(s.Pop() == 10);
            Debug.Assert(s.Pop() == 5);
        }

        public static void ObjectStackExample()
        {
            ObjectStack s = new ObjectStack();
            s.Push(true);
            s.Push(45);
            char c = (char) s.Pop();
        }

        public static void GenericStackExample()
        {
            Stack<bool> s1 = new Stack<bool>();
            s1.Push(true);
            s1.Push(false);
            Debug.Assert(s1.Pop() == false);

            Stack<char> s2 = new Stack<char>();
            s2.Push('a');
            s2.Push('b');
            Debug.Assert(s2.Pop() == 'b');
        }

        public static void GenericMethodsExample()
        {
            string a = "John";
            string b = "Kate";
            GenericMethods.Swap<string>(ref a, ref b);
            Debug.Assert(a == "Kate");
            Debug.Assert(b == "John");
        }
    }
}
