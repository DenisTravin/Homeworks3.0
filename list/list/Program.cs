using System;
using ListRealisation;

namespace ListProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List();
            for (var i = 0; i < 6; i++)
            {
                list.AddElement(i * i);
            }
            list.ListOutput();
            Console.WriteLine("{0} {0} ", list.GetElement(3), list.GetElementIndex(9));
            for (var i = 5; i >= 0; i--)
            {
                Console.WriteLine("{0}", list.DeleteElement(i * i));
                list.ListOutput();
            }
            Console.ReadLine();
        }
    }
}
