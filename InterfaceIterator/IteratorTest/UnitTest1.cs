using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InterfaceIterator;

namespace IteratorTest
{
    [TestClass]
    public class IteratorTest
    {
        [TestMethod]
        public void TreeMakingTest()
        {
            BinaryTree tree = new BinaryTree(10);
            Assert.AreEqual(10, tree.root.value);
        }

       [TestMethod]
       public void TreeIteratorTest()
        {
            int sum = 0;
            BinaryTree tree = new BinaryTree(10);
            tree.AddElement(5);
            tree.AddElement(7);
            tree.AddElement(11);
            tree.AddElement(15);
            tree.AddElement(14);
            tree.AddElement(17);
            List<int> elementList = new List<int>();
            foreach (int value in tree)
            {
                elementList.Add(value);
            }
            List<int> checkList = new List<int>();
            checkList.Add(10);
            checkList.Add(5);
            checkList.Add(7);
            checkList.Add(11);
            checkList.Add(15);
            checkList.Add(14);
            checkList.Add(17);
            Assert.AreEqual(checkList, elementList);
        }
    }
}
