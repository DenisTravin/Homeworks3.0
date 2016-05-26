using System;
using StackListRealisation;
using StackArrayRealisation;
using CalculatorNamespace;

namespace StackCalc
{
    public class Program
    {
        static void Main(string[] args)
        {
            const int numberStackElements = 5;
            var stack = new StackList();
            Console.WriteLine("Stack is empty? - {0}", stack.IsEmpty());
            for (var i = 1; i <= numberStackElements; i++)
            {
                stack.Push(i * i);
            }
            for (var i = 1; i <= numberStackElements; i++)
            {
                Console.Write("{0} ", stack.Pop());
            }
            Console.WriteLine("\nStack is empty? - {0}", stack.IsEmpty());
            var inputsting = "21/2+";
            Console.WriteLine("{0}", Calculator.CalculatorMethod(stack, inputsting));
            Console.ReadLine();
        }
    }
}
