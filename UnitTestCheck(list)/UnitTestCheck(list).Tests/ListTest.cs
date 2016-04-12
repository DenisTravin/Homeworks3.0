

namespace UnitTestCheckList.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using ListRealisation;

    [TestClass]
    public class ListTest
    {
        private List list;

        [TestInitialize]
        public void Initialize()
        {
           list = new List();
        }

        [TestMethod]
        public void AddTest()
        {
            Assert.IsTrue(list.IsEmpty());
            list.AddElement(1);
            Assert.IsFalse(list.IsEmpty());
        }

        [TestMethod]
        public void GetLengthTest()
        {
            list.AddElement(1);
            Assert.AreEqual(1, list.GetListLenght());
        }

        [TestMethod]
        public void DeleteTest()
        {
            list.AddElement(1);
            Assert.IsFalse(list.IsEmpty());
            list.DeleteElement(1);
            Assert.IsTrue(list.IsEmpty());
        }

        [TestMethod]
        public void GetElementIndexTest()
        {
            list.AddElement(1);
            Assert.AreEqual(0, list.GetElementIndex(1));
            list.AddElement(2);
            Assert.AreEqual(1, list.GetElementIndex(2));
            list.DeleteElement(1);
            Assert.AreEqual(0, list.GetElementIndex(2));
        }

        [TestMethod]
        public void GetElementTest()
        {
            list.AddElement(1);
            Assert.AreEqual(1, list.GetElement(0));
            list.AddElement(2);
            Assert.AreEqual(2, list.GetElement(1));
            list.DeleteElement(1);
            Assert.AreEqual(2, list.GetElement(0));
        }

        [TestMethod]
        public void DeleteWithoutAddTest()
        {
            Assert.AreEqual(false, list.DeleteElement(5));
        }

        [TestMethod]
        public void GetElementWithoutAddTest()
        {
            Assert.AreEqual(-1, list.GetElement(1));
        }

        [TestMethod]
        public void GetElementIndexWithoutAddTest()
        {
            Assert.AreEqual(-1, list.GetElementIndex(100));
        }
    }
}
