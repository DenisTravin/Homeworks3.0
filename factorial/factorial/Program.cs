using System;

namespace Factorial
{
    // class for calculating number factorial
    class Program
    {
        // main function
        static void Main(string[] args)
        {
            Console.Write("Input number: ");
            var inputString = Console.ReadLine();
            int number = Int32.Parse(inputString);
            Console.WriteLine("Number factorial is {0}", Factorial(number));
            Console.ReadLine();
        }

        // function for calculating factorial
        private static int Factorial(int number)
        {
            if (number > 0)
            {
                return number * Factorial(number - 1);
            }
            return 1;
        }
    }
}