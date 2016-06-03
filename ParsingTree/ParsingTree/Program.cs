using System;
using System.IO;

namespace ParsingTree
{
    public class Program
    {
        static void Main(string[] args)
        {
            ParsingBinaryTree binaryTree = new ParsingBinaryTree(ReadFromFile("input.txt"));
            binaryTree.Output();
            Console.WriteLine("\nCalculated expression: {0}", binaryTree.Calculate());
            Console.ReadLine();
        }

        private static string ReadFromFile(string inputFile)
        {
            using (StreamReader streamReader = new StreamReader(inputFile))
            {
                return (streamReader.ReadToEnd());
            };
        }
    }
}
