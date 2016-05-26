using System.Collections.Generic;
using System.Linq;
using StackInterfaceClass;

namespace StackListRealisation
{
    /// <summary>
    /// stack list realisation class
    /// </summary>
    public class StackList : StackInterface
    {
        /// <summary>
        /// array of stack elements
        /// </summary>
        private List<int> stackList;

        /// <summary>
        /// stack constructor
        /// </summary>
        public StackList()
        {
            stackList = new List<int>();
        }

        public bool IsEmpty()
        {
            return stackList.Count() == 0;
        }

        public void Push(int number)
        {
            stackList.Add(number);
        }

        public int Pop()
        {
            int temp = stackList.Last();
            stackList.RemoveAt(stackList.Count - 1);
            return temp;
        }
    }
}
