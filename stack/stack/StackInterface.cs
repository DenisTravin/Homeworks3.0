using System;

namespace StackInterfaceClass
{

    /// <summary>
    /// interface for stack class
    /// </summary>
    interface StackInterface
    {
        /// <summary>
        /// check the presence of the element's in stack
        /// </summary>
        /// <returns> Is stack empty - return "true" value
        /// in other way - "false" value</returns>
        bool IsEmpty();

        /// <summary>
        /// add element to the stack head
        /// </summary>
        /// <param name="number">number of adding element</param>
        void Push(int number);

        /// <summary>
        /// delete element from stack head
        /// </summary>
        /// <returns>stack head element</returns>
        int Pop();

    }
}