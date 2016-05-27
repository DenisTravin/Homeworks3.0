using System.Collections;
using System.Collections.Generic;

namespace InterfaceIterator
{
    /// <summary>
    /// tree element class
    /// </summary>
    public class TreeElement
    {
        public int value;
        public TreeElement parent;
        public TreeElement leftElement;
        public TreeElement rightElement;

        public TreeElement(int inputValue)
        {
            value = inputValue;
        }


    }

    /// <summary>
    /// tree realisation class
    /// </summary>
    public class BinaryTree : IEnumerable<int>
    {
        /// <summary>
        /// tree root
        /// </summary>
        public TreeElement root;

        /// <summary>
        /// tree constructor
        /// </summary>
        /// <param name="value">tree root</param>
        public BinaryTree(int value)
        {
            root = new TreeElement(value);
        }

        /// <summary>
        /// add element to tree
        /// </summary>
        /// <param name="value">input element value</param>
        public void AddElement(int value)
        {
            TreeElement temp = root;
            bool flag = true;
            while (flag)
            {
                if (value > temp.value)
                {
                    if (temp.rightElement == null)
                    {
                        temp.rightElement = new TreeElement(value);
                        temp.rightElement.parent = temp;
                        flag = false;
                    }
                    else
                    {
                        temp = temp.rightElement;
                    }
                }
                else
                {
                    if (temp.leftElement == null)
                    {
                        temp.leftElement = new TreeElement(value);
                        temp.leftElement.parent = temp;
                        flag = false;
                    }
                    else
                    {
                        temp = temp.leftElement;
                    }
                }
            }
        }

        /// <summary>
        /// Implementation for the GetEnumerator method.
        /// </summary>
        IEnumerator<int> IEnumerable<int>.GetEnumerator()
        {
            return (IEnumerator<int>)GetEnumeratorReal();
        }

        public TreeEnumenator GetEnumeratorReal()
        {
            return new TreeEnumenator(this);
        }

        /// <summary>
        /// tree enumenator method
        /// </summary>
        public class TreeEnumenator : IEnumerator<int>
        {

            BinaryTree tree;

            TreeElement current;

            /// <summary>
            /// tree enumenator constructor
            /// </summary>
            /// <param name="tree"></param>
            public TreeEnumenator(BinaryTree tree)
            {
                this.tree = tree;
                current = null;
            }

            /// <summary>
            /// move next method
            /// </summary>
            /// <returns></returns>
            public bool MoveNext()
            {
                if (current == null)
                {
                    current = tree.root;
                    return true;
                }
                if (current.leftElement != null)
                {
                    current = current.leftElement;
                }
                else
                {
                    if (current.rightElement != null)
                    {
                        current = current.rightElement;
                    }
                    else
                    {
                        while(current.parent != null && current == current.parent.rightElement)
                        {
                            current = current.parent;
                        }
                        if (current.parent != null)
                        {
                            current = current.parent.rightElement;
                        }
                    }
                }
                return current.parent != null;
            }

            /// <summary>
            /// reset tree method
            /// </summary>
            public void Reset()
            {
                current = tree.root;
            }

            /// <summary>
            /// give back current element value
            /// </summary>
            public int Current
            {
                get
                {
                    return current.value;
                }
            }

            object IEnumerator.Current
            {
                get
                {
                    return current.value;
                }
            }

            public void Dispose()
            {

            }
        }

        public IEnumerator GetEnumerator()
        {
            return new TreeEnumenator(this);
        }
    }
}