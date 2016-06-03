using Microsoft.VisualStudio.TestTools.UnitTesting;
using HashTableNamespace;

namespace HashTableTests
{
    [TestClass]
    public class HashTableTests
    {
        private HashTable hashTableByLengthFunc;
        private HashTable hashTableByLettersFunc;
        private HashTable hashTableByMultFunc;

        [TestInitialize]
        public void Initialize()
        {
            HashByLength hashByLength = new HashByLength();
            hashTableByLengthFunc = new HashTable(hashByLength);
            HashByLetters hashByLetters = new HashByLetters();
            hashTableByLettersFunc = new HashTable(hashByLetters);
            HashByMult hashByMult = new HashByMult();
            hashTableByMultFunc = new HashTable(hashByMult);
        }

        [TestMethod]
        public void AddMethodTest()
        {
            hashTableByLengthFunc.AddElement("word");
            Assert.IsTrue(hashTableByLengthFunc.CheckElementStanding("word"));
            hashTableByLettersFunc.AddElement("word");
            Assert.AreEqual(true, hashTableByLettersFunc.CheckElementStanding("word"));
            hashTableByMultFunc.AddElement("word");
            Assert.AreEqual(true, hashTableByMultFunc.CheckElementStanding("word"));
        }

        [TestMethod]
        public void DeleteMethodTest()
        {
            hashTableByLengthFunc.AddElement("word");
            Assert.AreEqual(true, hashTableByLengthFunc.DeleteHashElement("word"));
            Assert.AreEqual(false, hashTableByLengthFunc.CheckElementStanding("word"));
            hashTableByLettersFunc.AddElement("word");
            Assert.AreEqual(true, hashTableByLettersFunc.DeleteHashElement("word"));
            Assert.AreEqual(false, hashTableByLettersFunc.CheckElementStanding("word"));
            hashTableByMultFunc.AddElement("word");
            Assert.AreEqual(true, hashTableByMultFunc.DeleteHashElement("word"));
            Assert.AreEqual(false, hashTableByMultFunc.CheckElementStanding("word"));
        }

        [TestMethod]
        public void ComplexHashTableTest()
        {
            hashTableByMultFunc.AddElement("TheMoreIC");
            hashTableByMultFunc.AddElement("TheLess");
            hashTableByMultFunc.AddElement("ISee");
            Assert.AreEqual(true, hashTableByMultFunc.CheckElementStanding("TheLess"));
            Assert.AreEqual(true, hashTableByMultFunc.DeleteHashElement("TheLess"));
            Assert.AreEqual(false, hashTableByMultFunc.CheckElementStanding("TheLess"));
            Assert.AreEqual(true, hashTableByMultFunc.CheckElementStanding("TheMoreIC"));
            Assert.AreEqual(true, hashTableByMultFunc.CheckElementStanding("ISee"));
        }

    }
}