using System;

namespace SortArrayProgram
{
    // class for sort array
    class Program
    {
        // main function
        static void Main(string[] args)
        {
            const int arrayNumber = 5;
            int[,] array = new int[arrayNumber, arrayNumber] { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 8 }, { 1, 2, 3, 4, 5 }, { 9, 8, 7, 6, 5 }, { 5, 4, 3, 2, 1 } };
            Console.Write("Input array: ");
            ArrayOutput(array, arrayNumber);
            Console.ReadLine();
        }

        // array output function
        private static void ArrayOutput(int[,] array, int arrayNumber)
        {
            for (var i = 0; i < arrayNumber; i++)
            {
                Console.Write("\n");
                for (var j = 0; j < arrayNumber; j++)
                {
                    Console.Write("{0} ", array[i, j]);
                }
            }
        }

        // array spiral output function
        private static void ArraySpiralOutput(int[,] array, int arrayNumber)
        {
            int iCurrentElement = arrayNumber / 2 + 1;
            int jCurrentElement = arrayNumber / 2 + 1;
            for (var i = iCurrentElement; i )
        }
    }
}