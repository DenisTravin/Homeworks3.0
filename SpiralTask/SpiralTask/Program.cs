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
            ArrayOutput(array);
            Console.Write("\nOutput spiral element: ");
            ArraySpiralOutput(array);
            Console.ReadLine();
        }

        // array output function
        private static void ArrayOutput(int[,] array)
        {
            for (var i = 0; i < array.GetLength(0); i++)
            {
                Console.Write("\n");
                for (var j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write("{0} ", array[i, j]);
                }
            }
        }

        // array spiral output function
        private static void ArraySpiralOutput(int[,] array)
        {
            int iCurrentElement = array.GetLength(0) / 2;
            int jCurrentElement = array.GetLength(1) / 2;
            int step = 0;
            Console.Write("{0} ", array[iCurrentElement, jCurrentElement]);
            for (var k = 0; k < array.GetLength(0) / 2; k++)
            {
                step++;
                for (var i = 0; i < step; i++)
                {
                    iCurrentElement--;
                    Console.Write("{0} ", array[iCurrentElement, jCurrentElement]);
                }
                for (var j = 0; j < step; j++)
                {
                    jCurrentElement++;
                    Console.Write("{0} ", array[iCurrentElement, jCurrentElement]);
                }
                step++;
                for (var i = 0; i < step; i++)
                {
                    iCurrentElement++;
                    Console.Write("{0} ", array[iCurrentElement, jCurrentElement]);
                }
                for (var j = 0; j < step; j++)
                {
                    jCurrentElement--;
                    Console.Write("{0} ", array[iCurrentElement, jCurrentElement]);
                }
            }
            for (var i = 0; i < step; i++)
            {
                iCurrentElement--;
                Console.Write("{0} ", array[iCurrentElement, jCurrentElement]);
            }
        }
    }
}