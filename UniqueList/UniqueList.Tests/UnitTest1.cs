using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UniqueListRealisation;
using Exceptions;

namespace UniqueListProj.Tests
{
    [TestClass]
    public class UniqueListTest
    {
        private UniqueList testList;

        [TestInitialize()]
        public void Initialize()
        {
            testList = new UniqueList();
        }

        [TestMethod()]
        public void AddElementTest()
        {
            testList.AddElement(1);
            Assert.AreEqual(testList.GetListLength(), 1);
            Assert.AreEqual(testList.GetElement(0), 1);
        }

        [TestMethod()]
        public void DeleteElementTest()
        {
            testList.AddElement(5);
            testList.AddElement(10);
            testList.DeleteElement(5);
            Assert.AreEqual(1, testList.GetListLength());
            Assert.AreEqual(10, testList.GetElement(0));
        }

        [TestMethod()]
        [ExpectedException(typeof(LackElementException))]
        public void LackElementExceptionTest()
        {
            testList.DeleteElement(1);
        }

        [TestMethod()]
        [ExpectedException(typeof(StandingElementException))]
        public void StandingElementException()
        {
            testList.AddElement(1);
            testList.AddElement(1);
        }

        [TestMethod()]
        public void ComplexUniqueListTest()
        {
            for (var i = 0; i < 6; i++)
            {
                testList.AddElement(i * i);
            }
            Assert.AreEqual(testList.GetElement(3), 9);
            Assert.AreEqual(testList.GetElementIndex(9), 3);
            for (var i = 5; i >= 0; i--)
            {
                testList.DeleteElement(i * i);
            }
            Assert.AreEqual(testList.IsEmpty(), true);
        }

    }
}
