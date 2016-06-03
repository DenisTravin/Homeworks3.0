using System;

namespace ParsingTree
{
    /// <summary>
    /// division operator class
    /// </summary>
    class DivOperator : Operator
    {
        public override int Calculate()
        {
            return LeftChild.Calculate() / RightChild.Calculate();
        }

        public override void Output()
        {
            Console.Write("( / ");
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
