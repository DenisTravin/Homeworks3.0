using System;
using StackInterfaceClass;

namespace StackRealisation
{

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
            counter = 0;
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
