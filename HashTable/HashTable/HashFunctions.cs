using System;

namespace HashTableNamespace
{
    /// <summary>
    /// hash function main class
    /// </summary>
    public class HashFunctionClass
    {
        /// <summary>
        /// main method to calculate hash
        /// </summary>
        /// <param name="inputStr">input string</param>
        /// <param name="hashTableSize">hahs table size</param>
        /// <param name="userChoice"> user choice for hash function</param>
        /// <returns>calculated hash</returns>
        public static int Hash(string inputStr, int hashTableSize, int userChoice)
        {
            switch (userChoice)
            {
                case 1:
                    return HashByLength(inputStr, hashTableSize);
                case 2:
                    return HashByLetters(inputStr, hashTableSize);
                case 3:
                    return HashByMult(inputStr, hashTableSize);
                default:
                    throw new LackOfHashException();
            }

        }

        /// <summary>
        /// hash function by multiply
        /// </summary>
        /// <param name="value">input sting</param>
        /// <param name="size">hash table size</param>
        /// <returns>calculated hash</returns>
        private static int HashByMult(string value, int size)
        {
            int hash = 0;
            int mult = 1;
            for (var i = 0; i < value.Length; i++)
            {
                hash += Convert.ToInt32((value[i])) * mult;
                mult *= 29;
            }
            return (hash % size + size) % size;
        }

        /// <summary>
        /// hash function by letters sum
        /// </summary>
        /// <param name="value">input sting</param>
        /// <param name="size">hash table size</param>
        /// <returns>calculated hash</returns>
        private static int HashByLetters(string value, int size)
        {
            int sum = 0;
            foreach(char symbol in value)
            {
                sum += symbol;
            }
            return sum % size;
        }

        /// <summary>
        /// hash function by input string length
        /// </summary>
        /// <param name="value">input sting</param>
        /// <param name="size">hash table size</param>
        /// <returns>calculated hash</returns>
        private static int HashByLength(string value, int size)
        {
            return value.Length % size;
        }

    }
}
