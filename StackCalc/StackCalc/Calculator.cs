﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackInterfaceClass;

namespace CalculatorNamespace
{
    /// <summary>
    /// calculator realisation class
    /// </summary>
    public class Calculator
    {
        /// <summary>
        /// check does char is number
        /// </summary>
        /// <param name="inputChar">input char</param>
        /// <returns>does number</returns>
        private static bool IsNumber(char inputChar)
        {
            return inputChar >= '0' && inputChar <= '9';
        }

        /// <summary>
        /// check does char is operation
        /// </summary>
        /// <param name="inputChar">input char</param>
        /// <returns>does operation</returns>
        private static bool IsOperation(char inputChar)
        {
            return inputChar == '+' || inputChar == '-' || inputChar == '*' || inputChar == '/';
        }

        /// <summary>
        /// main calculator method
        /// </summary>
        /// <param name="inputStack">input stack</param>
        /// <param name="inputString">input string</param>
        /// <returns>calculated number</returns>
        public static int CalculatorMethod(StackInterface inputStack, string inputString)
        {
            for (var i = 0; i < inputString.Length; i++)
            {
                if (IsNumber(inputString[i]))
                {
                    inputStack.Push(inputString[i] - '0');
                    continue;
                }

                if (IsOperation(inputString[i]))
                {
                    int firstTemp;
                    int secondTemp;

                    int charTemp = inputString[i];

                    if (inputStack.IsEmpty())
                    {
                        throw new LackElementException();
                    }
                    else
                    {
                        secondTemp = inputStack.Pop();
                    }

                    if (inputStack.IsEmpty())
                    {
                        throw new LackElementException();
                    }
                    else
                    {
                        firstTemp = inputStack.Pop();
                    }

                    switch (charTemp)
                    {
                        case '+':
                            inputStack.Push(firstTemp + secondTemp);
                            break;
                        case '-':
                            inputStack.Push(firstTemp - secondTemp);
                            break;
                        case '*':
                            inputStack.Push(firstTemp * secondTemp);
                            break;
                        case '/':
                            inputStack.Push(firstTemp / secondTemp);
                            break;
                    }
                }

            }
            return inputStack.Pop();
        }

        [Serializable]
        public class LackElementException : ApplicationException
        {
            public LackElementException() { }
            public LackElementException(string message) : base(message) { }
            public LackElementException(string message, Exception inner) : base(message, inner) { }
            protected LackElementException(
              System.Runtime.Serialization.SerializationInfo info,
              System.Runtime.Serialization.StreamingContext context) : base(info, context)
            { }
        }

    }
}
