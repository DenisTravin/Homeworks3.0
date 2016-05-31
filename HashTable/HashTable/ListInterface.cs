
namespace ListNamespace
{
    interface ListInterface
    {
        /// <summary>
        /// add element to list
        /// </summary>
        /// <param name="newElement"> number of new element</param>
        void AddElement(string newElementValue);

        /// <summary>
        /// delete element form list
        /// </summary>
        /// <param name="elementValue">value of element to delete</param>
        /// <returns>Does elemment delete?</returns>
        bool DeleteElement(string elementValue);

        /// <summary>
        /// return list lenght
        /// </summary>
        /// <returns>lenght of list</returns>
        int GetListLenght();

        /// <summary>
        /// return element by index
        /// </summary>
        /// <param name="elementIndex">element index</param>
        /// <returns>element with input index(-1 if list don't 
        /// include element with input index</returns>
        string GetElement(int elementIndex);

        /// <summary>
        /// return index of element with input value
        /// </summary>
        /// <param name="elementValue">element value</param>
        /// <returns>index of element(-1 if list don't have element 
        ///  with input index</returns>
        int GetElementIndex(string elementValue);

        /// <summary>
        /// output list
        /// </summary>
        void ListOutput();
    }
}