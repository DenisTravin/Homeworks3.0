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
            HashByLength hash = new HashByLength();
            Assert.AreEqual(4, hash.Hash("word", 100));
        }

        [TestMethod]
        public void HashByLettersTest()
        {
            HashByLetters hash = new HashByLetters();
            Assert.AreEqual(44, hash.Hash("word", 100));
        }

        [TestMethod]
        public void HashByMultTest()
        {
            HashByMult hash = new HashByMult();
            Assert.AreEqual(12, hash.Hash("word", 100));
        }
    }
}
