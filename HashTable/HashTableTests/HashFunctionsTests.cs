using Microsoft.VisualStudio.TestTools.UnitTesting;
using HashTableNamespace;

namespace HashTableTests
{
    [TestClass]
    public class HashFunctionsTests
    {
        [TestMethod]
        public void HashByLengthTest()
        {
            Assert.AreEqual(4, HashFunctionClass.Hash("word", 100, 1));
        }

        [TestMethod]
        public void HashByLettersTest()
        {
            Assert.AreEqual(44, HashFunctionClass.Hash("word", 100, 2));
        }

        [TestMethod]
        public void HashByMultTest()
        {
            Assert.AreEqual(12, HashFunctionClass.Hash("word", 100, 3));
        }
    }
}
