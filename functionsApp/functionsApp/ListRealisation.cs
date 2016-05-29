using System;

namespace ListNamespace
{
    /// <summary>
    /// list realisation class
    /// </summary>
    public class List : ListInterface
    {
        /// <summary>
        /// element class
        /// </summary>
        private class Element
        {
            public int value;
            public Element next;

            public Element()
            {
                this.value = 0;
                this.next = null;
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

        public List()
        {
            this.listHead = null;
            this.listSize = 0;
        }

        public virtual void AddElement(int newElementNumber)
        {
            Element newElement = new Element();
            newElement.value = newElementNumber;

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

        public virtual bool DeleteElement(int elementNumber)
        {
            if (listHead == null)
            {
                return false;
            }
            if (listHead.value == elementNumber)
            {
                listHead = listHead.next;
                listSize--;
                return true;
            }
            Element tempElement = listHead;
            Element nextTempElement = listHead.next;
            while (tempElement.next != null)
            {
                if (nextTempElement.value == elementNumber)
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

        public int GetListLenght()
        {
            return listSize;
        }

        public int GetElement(int elementIndex)
        {
            if (elementIndex >= listSize)
            {
                return -1;
            }
            Element tempElement = listHead;
            for (var i = 0; i < elementIndex; i++)
            {
                tempElement = tempElement.next;
            }
            return tempElement.value;
        }

        public int GetElementIndex(int elementNumber)
        {
            Element tempElement = listHead;
            for (var i = 0; i < listSize; i++)
            {
                if (tempElement.value == elementNumber)
                {
                    return i;
                }
                tempElement = tempElement.next;
            }
            return -1;
        }

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

        public bool IsEmpty()
        {
            return listSize == 0;
        }
    }
}