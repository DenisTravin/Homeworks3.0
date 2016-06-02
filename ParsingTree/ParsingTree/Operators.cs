using System;

namespace ParsingTree
{
    public class Operator : AbstractTreeElement
    {
        private AbstractTreeElement leftChild;

        /// <summary>
        /// left child property
        /// </summary>
        public AbstractTreeElement LeftChild
        {
            get { return leftChild; }
            set { leftChild = value; }
        }


        private AbstractTreeElement rightChild;

        /// <summary>
        /// right child property
        /// </summary>
        public AbstractTreeElement RightChild
        {
            get { return rightChild; }
            set { rightChild = value; }
        }

        public override int Calculate()
        {
            throw new LackOfOperationexception();
        }

        public override void Output()
        {
            throw new LackOfOperationexception();
        }
    }

    /// <summary>
    /// plus operator class
    /// </summary>
    public class PlusOperator : Operator
    {
        public override int Calculate()
        {
            return LeftChild.Calculate() + RightChild.Calculate();
        }

        public override void Output()
        {
            Console.Write("( + ");
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

    /// <summary>
    /// multiplication operator class
    /// </summary>
    class MultOperator : Operator
    {
        public override int Calculate()
        {
            return LeftChild.Calculate() * RightChild.Calculate();
        }

        public override void Output()
        {
            Console.Write("( * ");
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
