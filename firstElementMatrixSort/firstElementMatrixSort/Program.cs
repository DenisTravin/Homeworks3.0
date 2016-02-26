using System;

namespace SortArrayProgram
{
    // class for sort matrix by first elements
    class Program
    {
        // main function
        static void Main(string[] args)
        {
            const int arrayNumberLine = 4;
            const int arrayNumberColumn = 5;
            int[,] array = new int[arrayNumberLine, arrayNumberColumn] { { 1, 5, 4, 2, 3 }, { 6, 7, 8, 9, 8 }, { 1, 2, 3, 4, 5 }, { 9, 8, 7, 6, 5 }};
            Console.Write("Input array: ");
            ArrayOutput(array);
            ArraySort(array);
            Console.Write("\nSorted array: ");
            ArrayOutput(array);
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

        // array sort function
        private static void ArraySort(int[,] array)
        {
            for (int i = 0; i < array.GetLength(1); i++)
            {
                for (int j = array.GetLength(1) - 1; j > i; j++)
                {
                    if (array[0, i] > array[0, j])
                    {
                        for (int k = 0; k < array.GetLength(0); ++k)
                        {
                            Swap(ref array[k, i], ref array[k, j]);
                        }
                    }
                }
            }
        }

        // swap function
        public static void Swap(ref int firstElement, ref int secondElement)
        {
            int temp = firstElement;
            firstElement = secondElement;
            secondElement = temp;
        }
    }
}