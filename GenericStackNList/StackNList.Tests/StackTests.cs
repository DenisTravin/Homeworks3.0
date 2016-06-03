using GenericStackNList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StackNList.Tests
{
    [TestClass]
    public class StackTests
    {
        [TestMethod()]
        public void MakingStackTest()
        {
            var stack = new GenericStack<int>();
            Assert.AreEqual(stack.IsEmpty(), true);
        }

        [TestMethod()]
        public void PushNPopElementStackTest()
        {
            var stack = new GenericStack<int>();
            stack.Push(5);
            Assert.AreEqual(stack.Pop(), 5);
        }

        [TestMethod()]
        public void StringStackTest()
        {
            var stack = new GenericStack<string>();
            stack.Push("word");
            Assert.AreEqual(stack.Pop(), "word");
        }

        [TestMethod()]
        public void ComplexTest()
        {
            var stack = new GenericStack<string>();
            for (var i = 1; i <= 5; i++)
            {
                stack.Push((i * i).ToString());
            }
            for (var i = 5; i >= 1; i--)
            {
                Assert.AreEqual(stack.Pop(), (i* i).ToString());
            }
        }
    }
}
