using System;

namespace ListNamespace
{

    class List : ListInterface
    {
        /// <summary>
        /// element class
        /// </summary>
        private class Element
        {
            public string value;
            public Element next;

            public Element()
            {
                this.value = "";
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

        public void AddElement(string newElementValue)
        {
            Element newElement = new Element();
            newElement.value = newElementValue;

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

        public bool DeleteElement(string elementValue)
        {
            if (listHead == null)
            {
                return false;
            }
            if (listHead.value == elementValue)
            {
                listHead = listHead.next;
                listSize--;
                return true;
            }
            Element tempElement = listHead;
            Element nextTempElement = listHead.next;
            while (tempElement.next != null)
            {
                if (nextTempElement.value == elementValue)
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

        public string GetElement(int elementIndex)
        {
            if (elementIndex >= listSize)
            {
                return "";
            }
            Element tempElement = listHead;
            for (var i = 0; i < elementIndex; i++)
            {
                tempElement = tempElement.next;
            }
            return tempElement.value;
        }

        public int GetElementIndex(string elementValue)
        {
            Element tempElement = listHead;
            for (var i = 0; i < listSize; i++)
            {
                if (tempElement.value == elementValue)
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
                return;
                //Console.WriteLine("List is empty");//coment for hash table realisation
            }
            Element tempElement = listHead;
            for (var i = 0; i < listSize; i++)
            {
                Console.Write("{0} ", tempElement.value);
                tempElement = tempElement.next;
            }
            Console.WriteLine();
        }
    }
}