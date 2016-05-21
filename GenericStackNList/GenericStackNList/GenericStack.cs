using StackInterfaceClass;

namespace GenericStackNList
{
    /// <summary>
    /// stack realisation class
    /// </summary>
    public class GenericStack<T> : StackInterface<T>
    {
        /// <summary>
        /// counter of stack elements
        /// </summary>
        private int counter;

        /// <summary>
        /// array of stack elements
        /// </summary>
        private T[] stackArray;

        /// <summary>
        /// maximum number of stack elements 
        /// </summary>
        private const int maxStackElements = 10;

        /// <summary>
        /// stack constructor
        /// </summary>
        public GenericStack()
        {
            stackArray = new T[maxStackElements];
            counter = 0;
        }

        public bool IsEmpty()
        {
            return counter == 0;
        }

        public void Push(T newValue)
        {
            stackArray[counter] = newValue;
            counter++;
        }

        public T Pop()
        {
            counter--;
            return stackArray[counter];
        }
    }
}
