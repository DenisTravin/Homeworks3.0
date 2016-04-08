using System;
using hashTableRealisation;

namespace ListProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            var hashTable = new HashTable();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\n1 - add element to hash table");
                Console.WriteLine("2 - delete element from hash table");
                Console.WriteLine("3 - check elelement standing");
                Console.WriteLine("4 - output hash table");
                Console.WriteLine("Other - exit");
                Console.Write("Your choice: ");
                int number = Convert.ToInt32(Console.ReadLine());
                switch (number)
                {
                    case 1:
                        Console.Write("Input string: ");
                        string newString = Console.ReadLine();
                        hashTable.AddElement(newString);
                        Console.WriteLine("Element added!");
                        break;
                    case 2:
                        Console.Write("Input string: ");
                        string delString = Console.ReadLine();
                        if (hashTable.DeleteHashElement(delString))
                        {
                            Console.WriteLine("Element deleted");
                        }
                        else
                        {
                            Console.WriteLine("Element don't deleted");
                        }
                        break;
                    case 3:
                        Console.Write("Input string: ");
                        string checkString = Console.ReadLine();
                        if (hashTable.CheckElementStanding(checkString))
                        {
                            Console.WriteLine("This element standing in hash table!");
                        }
                        else
                        {
                            Console.WriteLine("This element don't standing in hash table!");
                        }
                        break;
                    case 4:
                        hashTable.PrintHashTable();
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}
