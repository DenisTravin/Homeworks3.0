using System;

namespace ParsingTree
{
    /// <summary>
    /// calculating element
    /// </summary>
    public class Operand : AbstractTreeElement
    {
        private int element;

        /// <summary>
        /// element property
        /// </summary>
        public int Element
        {
            get { return element; }
            set { element = value; }
        }

        public override int Calculate()
        {
            return Convert.ToInt32(element);
        }

        public override void Output()
        {
            Console.Write("{0} ", element);
        }
    }
}
