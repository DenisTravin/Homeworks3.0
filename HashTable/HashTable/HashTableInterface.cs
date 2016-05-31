
namespace HashTableNamespace
{
    interface HashTableInterface
    {
        /// <summary>
        /// add element to hash table
        /// </summary>
        /// <param name="newElementValue">adding element value</param>
        void AddElement(string newElementValue);

        /// <summary>
        /// delete element from hash table
        /// </summary>
        /// <param name="deleteElementValue">deleting element value</param>
        /// <returns>does element deleted</returns>
        bool DeleteHashElement(string deleteElementValue);

        /// <summary>
        /// check does element in hash table
        /// </summary>
        /// <param name="checkElementValue">checking element value</param>
        /// <returns>does element in hash table</returns>
        bool CheckElementStanding(string checkElementValue);

        /// <summary>
        /// output hash table
        /// </summary>
        void PrintHashTable();
    }
}