using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericBubble
{
    class BubbleSort
    {
        static public List<T> Sort<T>(List<T> list, Func<T, T, bool> CompareFunc)
        {
            for (var i = 0; i < list.Count(); i++)
            {
                for (var j = 0; j < list.Count() - 1; j++)
                {
                    if (CompareFunc(list[j], list[j + 1]))
                    {
                        T highValue = list[j];

                        list[j] = list[j + 1];
                        list[j + 1] = highValue;
                    }
                }
            }
            return list;
        }
    }
    class Program
    {

        public static bool CompareObj(string x, string y)
        {
            return x.Length > y.Length;
        }

        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("pi");
            list.Add("pop");
            list.Add("p");
            list.Add("pipop");
            list.Add("pipo");

            List<string> sortedList = BubbleSort.Sort(list, CompareObj);
            for (var i = 0; i < 5; i++)
            {
                Console.WriteLine("{0}", list[i]);
            }
            Console.ReadLine();
        }

    }

}
