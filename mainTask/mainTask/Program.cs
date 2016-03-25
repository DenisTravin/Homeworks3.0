
namespace QueueProgram
{
    using System;
    using QueueRealisation;

    /// <summary>
    /// main program class(to show stack work)
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            const int numberQueueElements = 5;
            var queue = new Queue();
            Console.WriteLine("Queue is empty? - {0}", queue.IsEmpty());
            for (var i = 1; i <= numberQueueElements; i++)
            {
                queue.Enqueue(i * i, i % 3);
            }
            try
            {

                for (var i = 1; i <= numberQueueElements + 1; i++)
                {
                    Console.Write("{0} ", queue.Dequeue());
                }
            }   
            catch(ArgumentException)
            {
                Console.WriteLine("\nQueue is empty(exception).");
            }
            Console.WriteLine("\nQueue is empty? - {0}", queue.IsEmpty());
            Console.ReadLine();
        }
    }
}