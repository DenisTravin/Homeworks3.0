using System;
using ListRealisation;
using HashTableInterfaceClass;

namespace hashTableRealisation
{
    class HashTable : HashTableInterface
    {

        private const int arraySize = 100;

        private List[] listArray;

        public HashTable()
        {
            listArray = new List[arraySize];

            for (var i = 0; i < arraySize; i++)
            {
                listArray[i] = new List();
            }
        }

        private int HashFunction(string value)
        {
            int hash = 0;
            int mult = 1;
            for (var i = 0; i < value.Length; i++)
            {
                hash += Convert.ToInt32((value[i])) * mult;
                mult *= 29;
            }
            return (hash % arraySize + arraySize) % arraySize;
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
