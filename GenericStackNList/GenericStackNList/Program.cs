using System;

namespace GenericStackNList
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberStackElements = 5;
            //Generic list check
            var list = new GenericList<string>();
            for (var i = 1; i <= numberStackElements; i++)
            {
                list.AddElement((i * i).ToString());
            }
            list.ListOutput();
            list.DeleteElement("25");
            list.ListOutput();
            Console.WriteLine("{0}", list.GetElementIndex("4"));

            //ListEnumerator check
            var listEnum = new GenericList<int>();
            for (var i = 0; i < 5; i++)
            {
                listEnum.AddElement(i);
            }
            foreach (var value in listEnum)
            {
                Console.WriteLine("{0}", value);
            }

            Console.ReadLine();
        }
    }
}
