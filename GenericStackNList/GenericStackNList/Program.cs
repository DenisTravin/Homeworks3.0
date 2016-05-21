using System;

namespace GenericStackNList
{
    class Program
    {
        static void Main(string[] args)
        {
            const int numberStackElements = 5;
            var stack = new GenericStack<string>();
            Console.WriteLine("Stack is empty? - {0}", stack.IsEmpty());
            for (var i = 1; i <= numberStackElements; i++)
            {
                stack.Push((i * i).ToString());
            }
            for (var i = 1; i <= numberStackElements; i++)
            {
                Console.Write("{0} ", stack.Pop());
            }
            Console.WriteLine("\nStack is empty? - {0}", stack.IsEmpty());
            Console.ReadLine();
        }
    }
}
