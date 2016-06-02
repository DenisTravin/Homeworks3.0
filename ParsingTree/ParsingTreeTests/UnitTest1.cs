using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParsingTree;

namespace ParsingTreeTests
{
    [TestClass]
    public class ParsingTreeTests
    {
        [TestMethod]
        public void PlusOperationTest()
        {
            ParsingBinaryTree binaryTree = new ParsingBinaryTree("(+ 10 20)");
            Assert.AreEqual(30, binaryTree.Calculate());
        }

        [TestMethod]
        public void MinusOperationTest()
        {
            ParsingBinaryTree binaryTree = new ParsingBinaryTree("(- 20 10)");
            Assert.AreEqual(10, binaryTree.Calculate());
        }

        [TestMethod]
        public void MultOperationTest()
        {
            ParsingBinaryTree binaryTree = new ParsingBinaryTree("(* 10 20)");
            Assert.AreEqual(200, binaryTree.Calculate());
        }

        [TestMethod]
        public void DivOperationTest()
        {
            ParsingBinaryTree binaryTree = new ParsingBinaryTree("(/ 20 10)");
            Assert.AreEqual(2, binaryTree.Calculate());
        }

        [TestMethod]
        public void ComplexTest()
        {
            ParsingBinaryTree binaryTree = new ParsingBinaryTree("(+ (* (- 40 39) (/ 30 5)) 20)");
            Assert.AreEqual(26, binaryTree.Calculate());
        }
    }
}
