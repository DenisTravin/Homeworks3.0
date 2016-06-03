namespace ParsingTree
{

    /// <summary>
    /// binary parsing tree class
    /// </summary>
    public class ParsingBinaryTree
    {
        /// <summary>
        /// binary tree root
        /// </summary>
        private AbstractTreeElement treeRoot;

        /// <summary>
        /// ParsingBinaryTree constructor
        /// </summary>
        /// <param name="value">input string</param>
        public ParsingBinaryTree(string value)
        {
            int currentNumber = 0;
            CreateChild(ref treeRoot, value, ref currentNumber);
        }

        /// <summary>
        /// making childs for tree element
        /// </summary>
        /// <param name="element">current element</param>
        /// <param name="value">input string</param>
        /// <param name="currentNumber">current symbol in string</param>
        private void CreateChild(ref AbstractTreeElement element, string value, ref int currentNumber)
        {
            if (currentNumber >= value.Length)
            {
                return;
            }
            while (value[currentNumber] == ' ' || value[currentNumber] == ')')
            {
                currentNumber++;
            }
            if (value[currentNumber] == '(')
            {
                currentNumber++;
                Operator newOpertator;
                switch (value[currentNumber])
                {
                    case '+':
                        newOpertator = new PlusOperator();
                        break;
                    case '-':
                        newOpertator = new MinusOperator();
                        break;
                    case '*':
                        newOpertator = new MultOperator();
                        break;
                    case '/':
                        newOpertator = new DivOperator();
                        break;
                    default:
                        throw new LackOfOperationexception();
                }
                currentNumber++;
                var newElement = newOpertator.LeftChild;
                CreateChild(ref newElement, value, ref currentNumber);
                newOpertator.LeftChild = newElement;
                if (value[currentNumber] == ')')
                {
                    currentNumber++;
                }
                newElement = newOpertator.RightChild;
                CreateChild(ref newElement, value, ref currentNumber);
                newOpertator.RightChild = newElement;
                element = newOpertator;
            }
            else
            {
                Operand newOperand = new Operand();
                newOperand.Element = 0;
                while (value[currentNumber] != ' ')
                {
                    if (value[currentNumber] == ')')
                    {
                        break;
                    }
                    newOperand.Element = newOperand.Element * 10 + (value[currentNumber] - '0');
                    currentNumber++;
                }
                element = newOperand;
            }
        }

        /// <summary>
        /// output tree
        /// </summary>
        public void Output()
        {
            treeRoot.Output();
        }

        /// <summary>
        /// calculate expression 
        /// </summary>
        /// <returns>calculated expression value</returns>
        public int Calculate()
        {
            return treeRoot.Calculate();
        }

    }
}
