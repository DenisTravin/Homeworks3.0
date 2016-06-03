namespace HashTableNamespace
{
    /// <summary>
    /// hash function class interfase
    /// </summary>
    public interface HashFuncInterface
    {
        /// <summary>
        /// hash calculating function
        /// </summary>
        /// <param name="value">input str</param>
        /// <param name="size">hash table size</param>
        /// <returns>calculated hash</returns>
        int Hash(string value, int size);
    }
}
