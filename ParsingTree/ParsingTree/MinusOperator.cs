using System;

namespace ParsingTree
{
    /// <summary>
    /// minus operator class
    /// </summary>
    class MinusOperator : Operator
    {
        public override int Calculate()
        {
            return LeftChild.Calculate() - RightChild.Calculate();
        }

        public override void Output()
        {
            Console.Write("( - ");
            if (LeftChild != null)
            {
                LeftChild.Output();
            }
            if (RightChild != null)
            {
                RightChild.Output();
            }
            Console.Write(") ");
        }
    }
}
