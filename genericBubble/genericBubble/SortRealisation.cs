using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericBubbleRealisation
{
    public class SortRealisation<T>
    {
        public List<T> BubbleSort(List<T> inputList, Func<T, T, bool> compareFunc)
        {
            for (var i = 0; i < inputList.Count(); i++)
            {
                for (var j = 0; j < inputList.Count(); j++)
                {
                    if (compareFunc(inputList[j], inputList[j+1]))
                    {
                        T highValue = inputList[j];

                        inputList[j] = inputList[j + 1];
                        inputList[j + 1] = highValue;
                    }
                }
            }
            return inputList;
        }
    }
}
