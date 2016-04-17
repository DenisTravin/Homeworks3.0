using System;
using UniqueListRealisation;

namespace ListProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new UniqueList();
            for (var i = 0; i < 6; i++)
            {
                list.AddElement(i * i);
            }
            //list.AddElement(25);
            list.ListOutput();
            Console.WriteLine("{0} {0} ", list.GetElement(3), list.GetElementIndex(9));
            list.DeleteElement(26);
            for (var i = 5; i >= 0; i--)
            {
                Console.WriteLine("{0}", list.DeleteElement(i * i));
                list.ListOutput();
            }
            Console.ReadLine();
        }
    }
}