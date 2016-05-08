using System;
using ListRealisation;
using Functions;

namespace FunctionsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List();
            for (var i = 1; i < 4; i++)
            {
                list.AddElement(i);
            }
            list.ListOutput();

            List mapList = FunctionsClass.Map(list, x => x * 2);
            mapList.ListOutput();

            List filterList = FunctionsClass.Filter(list, x => x % 2 == 1);
            filterList.ListOutput();

            Console.WriteLine("{0}", FunctionsClass.Fold(list, 1, (acc, elem) => acc * elem));
            Console.ReadLine();
        }
    }
}