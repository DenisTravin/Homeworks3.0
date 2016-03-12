using System;

namespace Fibonacci
{
    // class for calculating fibonacci numbers
    class Program
    {
        // main function
        static void Main(string[] args)
        {
            Console.Write("Input number: ");
            var inputString = Console.ReadLine();
            int number = Int32.Parse(inputString);
            Console.WriteLine("{0} fibonacci number is {1}", number, Fibonacci(number));
            Console.ReadLine();
        }

        // function for calculating fibonacci number
        private static int Fibonacci(int number)
        {
            int currentNumber = 1;
            int previousNumber = 1;
            for (var i = 2; i < number; i++)
            {
                currentNumber += previousNumber;
                previousNumber -= currentNumber;
                previousNumber = -previousNumber;
            }
            return currentNumber;
        }
    }
}