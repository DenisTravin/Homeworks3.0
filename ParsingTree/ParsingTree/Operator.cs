using System;

namespace ParsingTree
{
    public abstract class Operator : AbstractTreeElement
    {

        /// <summary>
        /// left child property
        /// </summary>
        public AbstractTreeElement LeftChild
        {
            get; set;
        }

        /// <summary>
        /// right child property
        /// </summary>
        public AbstractTreeElement RightChild
        {
            get; set;
        }

        public abstract int Calculate();

        public abstract void Output();
    }

}
