using System;
<<<<<<< HEAD:UnitTestCheck(list)/UnitTestCheck(list)/Program.cs
using ListRealisation;
=======
>>>>>>> 4(2s)_04.03.2016:UniqueList/UniqueList/Program.cs

namespace ListProgram
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD:UnitTestCheck(list)/UnitTestCheck(list)/Program.cs
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
=======
>>>>>>> 4(2s)_04.03.2016:UniqueList/UniqueList/Program.cs
        }
    }
}   