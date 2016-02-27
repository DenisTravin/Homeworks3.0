using System;

namespace StackRealisation
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

    /// <summary>
    /// stack realisation class
    /// </summary>
    class Stack : StackInterface
    {
        /// <summary>
        /// counter of stack elements
        /// </summary>
        private int counter;

        /// <summary>
        /// array of stack elements
        /// </summary>
        private int[] stackArray;

        /// <summary>
        /// maximum number of stack elements 
        /// </summary>
        private const int maxStackElements = 10;

        /// <summary>
        /// stack constructor
        /// </summary>
        public Stack()
        {
            stackArray = new int[maxStackElements];
        }

        public bool IsEmpty()
        {
            return counter == 0;
        }

        public void Push(int number)
        {
            stackArray[counter] = number;
            counter++;
        }

        public int Pop()
        {
            counter--;
            return stackArray[counter];
        }
    }
}
