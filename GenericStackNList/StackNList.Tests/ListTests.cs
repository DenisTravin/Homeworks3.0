using GenericStackNList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StackNList.Tests
{
    [TestClass]
    public class ListTests
    {
        [TestMethod()]
        public void MakingListTest()
        {
            var list = new GenericList<int>();
            Assert.AreEqual(list.IsEmpty(), true);
        }

        [TestMethod()]
        public void AddElementListTest()
        {
            var list = new GenericList<int>();
            list.AddElement(5);
            Assert.AreEqual(list.GetElement(0), 5);
        }

        [TestMethod()]
        public void DeleteElementListTest()
        {
            var list = new GenericList<int>();
            list.AddElement(5);
            Assert.AreEqual(true, list.DeleteElement(5));
            Assert.AreEqual(true, list.IsEmpty());
        }

        [TestMethod()]
        public void StringListTest()
        {
            var list = new GenericList<string>();
            list.AddElement("word");
            Assert.AreEqual(list.GetElement(0), "word");
        }

        [TestMethod()]
        public void EnumeratorListTest()
        {
            var list = new GenericList<int>();
            for (var i = 0; i < 5; i++)
            {
                list.AddElement(i);
            }
            int counter = 0;
            foreach (var value in list)
            {
                Assert.AreEqual(value, list.GetElement(counter));
                counter++;
            }
        }
    }
}
