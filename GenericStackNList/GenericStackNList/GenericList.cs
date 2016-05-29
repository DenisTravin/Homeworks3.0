using System;
using System.Collections;
using System.Collections.Generic;

namespace GenericStackNList
{
    public class GenericList<T> : IEnumerable<T>
    {
        /// <summary>
        /// element class
        /// </summary>
        private class Element
        {
            private T valueField;

            /// <summary>
            /// property for valueField
            /// </summary>
            public T value
            {
                get { return valueField; }
                set { valueField = value; }
            }

            private Element nextElementField;

            /// <summary>
            /// property for nextElementField
            /// </summary>
            public Element next
            {
                get { return nextElementField; }
                set { nextElementField = value; }
            }

            public Element(T newValue)
            {
                value = newValue;
            }
        }

        /// <summary>
        /// list head
        /// </summary>
        private Element listHead;

        /// <summary>
        /// size of list
        /// </summary>
        private int listSize;


        /// <summary>
        /// add element to list
        /// </summary>
        /// <param name="newElementValue"> value of new element</param>
        public void AddElement(T newElementValue)
        {
            Element newElement = new Element(newElementValue);


            if (listSize == 0)
            {
                listHead = newElement;
            }
            else
            {
                Element tempElement = listHead;
                while (tempElement.next != null)
                {
                    tempElement = tempElement.next;
                }
                tempElement.next = newElement;
            }
            listSize++;
        }

        /// <summary>
        /// delete element form list
        /// </summary>
        /// <param name="elementNumber">value of element to delete</param>
        /// <returns>Does elemment delete?</returns>
        public bool DeleteElement(T elementNumber)
        {
            if (listHead == null)
            {
                return false;
            }
            if (listHead.value.Equals(elementNumber))
            {
                listHead = listHead.next;
                listSize--;
                return true;
            }
            Element tempElement = listHead;
            Element nextTempElement = listHead.next;
            while (tempElement.next != null)
            {
                if (nextTempElement.value.Equals(elementNumber))
                {
                    tempElement.next = nextTempElement.next;
                    listSize--;
                    return true;
                }
                tempElement = nextTempElement;
                nextTempElement = nextTempElement.next;
            }
            return false;
        }

        /// <summary>
        /// return list lenght
        /// </summary>
        /// <returns>lenght of list</returns>
        public int GetListLenght()
        {
            return listSize;
        }

        /// <summary>
        /// check list emptiness
        /// </summary>
        /// <returns>if list empty - return true, other - false</returns>
        public bool IsEmpty()
        {
            return listSize == 0;
        }

        /// <summary>
        /// return element by index
        /// </summary>
        /// <param name="elementIndex">element index</param>
        /// <returns>element with input index(-1 if list don't 
        /// include element with input index</returns>
        public T GetElement(int elementIndex)
        {
            if (elementIndex >= listSize)
            {
                throw new LackElementException();
            }
            Element tempElement = listHead;
            for (var i = 0; i < elementIndex; i++)
            {
                tempElement = tempElement.next;
            }
            return tempElement.value;
        }

        /// <summary>
        /// returnn index of element with input number
        /// </summary>
        /// <param name="elementNumber">element number</param>
        /// <returns>index of element(-1 if list don't have element 
        ///  with input index</returns>
        public int GetElementIndex(T elementValue)
        {
            Element tempElement = listHead;
            for (var i = 0; i < listSize; i++)
            {
                if (tempElement.value.Equals(elementValue))
                {
                    return i;
                }
                tempElement = tempElement.next;
            }
            return -1;
        }

        /// <summary>
        /// output list
        /// </summary>
        public void ListOutput()
        {
            if (listHead == null)
            {
                Console.WriteLine("List is empty");
            }
            Element tempElement = listHead;
            for (var i = 0; i < listSize; i++)
            {
                Console.Write("{0} ", tempElement.value);
                tempElement = tempElement.next;
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Implementation for the GetEnumerator method.
        /// </summary>
        /// <returns></returns>
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return (IEnumerator<T>)GetEnumeratorReal();
        }

        public ListEnumerator GetEnumeratorReal()
        {
            return new ListEnumerator(this);
        }

        /// <summary>
        /// Implementation for the ListEnumerator method.
        /// </summary>
        public class ListEnumerator : IEnumerator<T>
        {

            int pos = -1;

            GenericList<T> list;

            Element curElement;

            /// <summary>
            /// ListEnumerator constructor
            /// </summary>
            /// <param name="list"></param>
            public ListEnumerator(GenericList<T> list)
            {
                this.list = list;
                curElement = null;
            }

            /// <summary>
            /// Take next list element
            /// </summary>
            /// <returns>Does element contains in list</returns>
            public bool MoveNext()
            {
                if (curElement != null)
                {
                    curElement = curElement.next;
                }
                else
                {
                    curElement = list.listHead;
                }
                pos++;
                return pos < list.GetListLenght();
            }

            /// <summary>
            /// Reset ListEnumerator
            /// </summary>
            public void Reset()
            {
                pos = -1;
                curElement = null;                
            }

            /// <summary>
            /// Get current list element
            /// </summary>
            public T Current
            {
                get
                {
                    return curElement.value;
                }
            }

            /// <summary>
            /// Get current list element in enumerator
            /// </summary>
            object IEnumerator.Current
            {
                get
                {
                    return curElement.value;
                }
            }

            public void Dispose()
            {
            }
        }

        public IEnumerator GetEnumerator()
        {
            return new ListEnumerator(this);
        }

        /// <summary>
        /// Exeption call's if element don't standing in list
        /// </summary>
        [Serializable]
        public class LackElementException : ApplicationException
        {
            public LackElementException() { }
            public LackElementException(string message) : base(message) { }
            public LackElementException(string message, Exception inner) : base(message, inner) { }
            protected LackElementException(
              System.Runtime.Serialization.SerializationInfo info,
              System.Runtime.Serialization.StreamingContext context) : base(info, context)
            { }
        }
    }   
}

