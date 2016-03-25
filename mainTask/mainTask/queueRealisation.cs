
namespace QueueRealisation
{
    using System;

    /// <summary>
    /// interface for queue class
    /// </summary>
    interface QueueInterface
    {
        /// <summary>
        /// check the presence of the element's in queue
        /// </summary>
        /// <returns> Is queue empty - return "true" value
        /// in other way - "false" value</returns>
        bool IsEmpty();

        /// <summary>
        /// add element in the queue
        /// </summary>
        /// <param name="number">number of adding element</param>
        /// <param name="priority">priority of adding element</param>
        void Enqueue(int number, int priority);

        /// <summary>
        /// delete element with max priority from queue
        /// </summary>
        /// <returns>element with max priority</returns>
        int Dequeue();

    }

    /// <summary>
    /// stack realisation class
    /// </summary>
    class Queue : QueueInterface
    {
        /// <summary>
        /// counter of queue elements
        /// </summary>
        private int counter;

        /// <summary>
        /// array of queue elements
        /// </summary>
        private int[] queueArray;

        /// <summary>
        /// array of elements priority
        /// </summary>
        private int[] queueElementPriority;

        /// <summary>
        /// maximum number of queue elements 
        /// </summary>
        private const int maxQueueElements = 10;

        /// <summary>
        /// queue constructor
        /// </summary>
        public Queue()
        {
            queueArray = new int[maxQueueElements];
            queueElementPriority = new int[maxQueueElements];
        }

        public bool IsEmpty()
        {
            return counter == 0;
        }

        public void Enqueue(int number, int priority)
        {
            queueArray[counter] = number;
            queueElementPriority[counter] = priority;
            counter++;
        }

        public int Dequeue()
        {
            if (counter == 0)
            {
                throw new System.ArgumentException("Queue cannot be null", "queue");
            }
            var maxPriorityNumber = 0;
            for (var i = counter - 1; i >= 0; i--)
            {
                if (queueElementPriority[maxPriorityNumber] <= queueElementPriority[i])
                {
                    maxPriorityNumber = i;
                }   
            }
            counter--;
            var tempForResult = queueArray[maxPriorityNumber];
            for (var i = maxPriorityNumber; i < counter; i++)
            {
                queueArray[i] = queueArray[i + 1];
                queueElementPriority[i] = queueElementPriority[i + 1];
            }
            return tempForResult;
        }
    }
}