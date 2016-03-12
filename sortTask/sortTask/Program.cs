using System;

namespace SortArrayProgram
{
    // class for sort array
    class Program
    {
        // main function
        static void Main(string[] args)
        {
            const int arrayNumber = 10;
            int[] array = new int[arrayNumber] {5, 4, 10, 3, 9, 7, 1, 2, 6, 8};
            Console.Write("Input array: ");
            ArrayOutput(array);
            ArraySort(array);
            Console.Write("\nOutput array: ");
            ArrayOutput(array);
            Console.ReadLine();
        }

        // array output function
        private static void ArrayOutput(int[] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
        }

        // sort function
        private static void ArraySort(int[] array)
        {
            for (var i = 1; i < array.Length; i++)
            {
                var currentNumber = array[i];
                var j = i;
                while (j > 0 && currentNumber < array[j - 1])
                {
                    array[j] = array[j - 1];
                    j--;
                }
                array[j] = currentNumber;
            }
        }
    }
}