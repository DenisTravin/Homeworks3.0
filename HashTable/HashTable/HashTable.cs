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

        private int userChoise;

        /// <summary>
        /// hash table constructor
        /// </summary>
        /// <param name="userInput">user choice for hash function</param>
        public HashTable(int userInput)
        {
            listArray = new List[arraySize];

            userChoise = userInput;

            for (var i = 0; i < arraySize; i++)
            {
                listArray[i] = new List();
            }
        }

        private int HashFunction(string value)
        {
            return HashFunctionClass.Hash(value, arraySize, userChoise);
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