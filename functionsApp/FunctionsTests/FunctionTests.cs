using ListNamespace;
using Functions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FunctionsTests
{
    [TestClass]
    public class FunctionTests
    {
        private List list;

        private const int listSize = 4;

        [TestInitialize()]
        public void Initialize()
        {
            list = new List();
            for (var i = 1; i < listSize; i++)
            {
                list.AddElement(i);
            }
        }

        [TestMethod()]
        public void MapFunctionTest()
        {
            List mapList = FunctionsClass.Map(list, x => x * 2);
            for (var i = 1; i < listSize; i++)
            {
                Assert.AreEqual(i * 2, mapList.GetElement(i - 1));
            }
        }

        [TestMethod()]
        public void FilterFunctionTest()
        {
            List filterList = FunctionsClass.Filter(list, x => x % 2 == 1);
            Assert.AreEqual(filterList.GetElement(0), 1);
            Assert.AreEqual(filterList.GetElement(1), 3);
        }

        [TestMethod()]
        public void FildFunctionTest()
        {
            Assert.AreEqual(6, FunctionsClass.Fold(list, 1, (acc, elem) => acc * elem));
        }
    }
}
