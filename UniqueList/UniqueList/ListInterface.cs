using System;

namespace ListInterfaceClass
{
    /// <summary>
    /// list interface class
    /// </summary>
    interface ListInterface
    {
        /// <summary>
        /// add element to list
        /// </summary>
        /// <param name="newElement"> number of new element</param>
        void AddElement(int newElementNumber);

        /// <summary>
        /// delete element form list
        /// </summary>
        /// <param name="elementNumber">number of element to delete</param>
        /// <returns>Does elemment delete?</returns>
        bool DeleteElement(int elementNumber);

        /// <summary>
        /// return list lenght
        /// </summary>
        /// <returns>lenght of list</returns>
        int GetListLength();

        /// <summary>
        /// return element by index
        /// </summary>
        /// <param name="elementIndex">element index</param>
        /// <returns>element with input index(-1 if list don't 
        /// include element with input index</returns>
        int GetElement(int elementIndex);

        /// <summary>
        /// returnn index of element with input number
        /// </summary>
        /// <param name="elementNumber">element number</param>
        /// <returns>index of element(-1 if list don't have element 
        ///  with input index</returns>
        int GetElementIndex(int elementNumber);

        /// <summary>
        /// output list
        /// </summary>
        void ListOutput();


        /// <summary>
        /// check list emptiness
        /// </summary>
        /// <returns>if list empty - return true, other - false</returns>
        bool IsEmpty();
    }
}
