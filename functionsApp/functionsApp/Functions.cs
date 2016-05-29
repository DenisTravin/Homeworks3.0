using System;
using ListNamespace;

namespace Functions
{
    /// <summary>
    /// functions class
    /// </summary>
    public static class FunctionsClass
    {
        /// <summary>
        /// map function realization
        /// </summary>
        /// <param name="list">input list</param>
        /// <param name="function">input function</param>
        /// <returns>map transformed list</returns>
        public static List Map(List list, Func<int, int> function)
        {
            List mapList = new List();
            for (var i = 0; i < list.GetListLenght(); i++)
            {
                mapList.AddElement(function(list.GetElement(i)));
            }
            return mapList;
        }

        /// <summary>
        /// filter function realization
        /// </summary>
        /// <param name="list">input list</param>
        /// <param name="function">input function</param>
        /// <returns>filter transformed list</returns>
        public static List Filter(List list, Func<int, bool> function)
        {
            List filterList = new List();
            for (var i = 0; i < list.GetListLenght(); i++)
            {
                if (function(list.GetElement(i)))
                {
                    filterList.AddElement(list.GetElement(i));
                }
            }
            return filterList;
        }

        /// <summary>
        /// fold function realization
        /// </summary>
        /// <param name="list">input list</param>
        /// <param name="initValue">initialization number value</param>
        /// <param name="function">input function</param>
        /// <returns>next accanuleted value</returns>
        public static int Fold(List list, int initValue, Func<int, int, int> function)
        {
            for (var i = 0; i < list.GetListLenght(); i++)
            {
                initValue = function(initValue, list.GetElement(i));
            }
            return initValue;
        }
    }


}
