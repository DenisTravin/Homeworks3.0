using System;

namespace HashTableNamespace
{

    /// <summary>
    /// hash by length class
    /// </summary>
    public class HashByLength : HashFuncInterface
    {
        public int Hash(string value, int size)
        {
            return value.Length % size;
        }
    }

    /// <summary>
    /// hash by letters class
    /// </summary>
    public class HashByLetters : HashFuncInterface
    {
        public int Hash(string value, int size)
        {
            int sum = 0;
            foreach (char symbol in value)
            {
                sum += symbol;
            }
            return sum % size;
        }
    }

    /// <summary>
    /// hash by mult class
    /// </summary>
    public class HashByMult : HashFuncInterface
    {
        public int Hash(string value, int size)
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
    }
}
