using System;
using ListNamespace;

namespace HashTableNamespace
{
    /// <summary>
    /// hash table class realisation
    /// </summary>
    public class HashTable : HashTableInterface
    {

        private const int arraySize = 100;

        private List[] listArray;

        private Func<string, int, int> inputHash;

        /// <summary>
        /// hash table constructor
        /// </summary>
        /// <param name="userInput">user choice for hash function</param>
        public HashTable(Func<string, int, int> hash)
        {
            listArray = new List[arraySize];
            inputHash = hash;
            for (var i = 0; i < arraySize; i++)
            {
                listArray[i] = new List();
            }
        }

        private int HashFunction(string value)
        {
            return inputHash(value, arraySize);
        }


        public void AddElement(string newElementValue)
        {
            listArray[HashFunction(newElementValue)].AddElement(newElementValue);
        }

        public bool DeleteHashElement(string deleteElementValue)
        {
            return listArray[HashFunction(deleteElementValue)].DeleteElement(deleteElementValue);
        }

        public bool CheckElementStanding(string checkElementValue)
        {
            return listArray[HashFunction(checkElementValue)].GetElementIndex(checkElementValue) >= 0;
        }

        public void PrintHashTable()
        {
            for (int i = 0; i < arraySize; ++i)
            {
                listArray[i].ListOutput();
            }
        }
    }
}