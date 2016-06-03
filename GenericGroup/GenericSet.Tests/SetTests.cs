using System;using Microsoft.VisualStudio.TestTools.UnitTesting;
using GenericSetNamespace;

namespace GenericSet.Tests
{
    [TestClass]
    public class SetTests
    {
        private GenericSet<int> twoFold;
        private GenericSet<int> threeFold;
        private const int elementsNumber = 20;

        [TestInitialize()]
        public void Initialize()
        {
            twoFold = new GenericSet<int>();
            threeFold = new GenericSet<int>();
            for (var i = 1; i < elementsNumber; i++)
            {
                if (i % 2 == 0)
                {
                    twoFold.AddElement(i);
                }
                if (i % 3 == 0)
                {
                    threeFold.AddElement(i);
                }
            }
        }

        [TestMethod()]
        public void MakingSetTest()
        {
            for (var i = 1; i < elementsNumber / 2; i++)
            {
                Assert.AreEqual(true, twoFold.ElementContains(i * 2));
            }
        }

        [TestMethod()]
        public void ComboSetTest()
        {
            GenericSet<int> comboSet = twoFold.SetCombo(threeFold);
            for (var i = 1; i < elementsNumber; i++)
            {
                if (i % 2 == 0 || i % 3 == 0)
                {
                    Assert.AreEqual(true, comboSet.ElementContains(i));
                }
            }
        }

        [TestMethod()]
        public void CrossSetTest()
        {
            GenericSet<int> crossSet = twoFold.SetCombo(threeFold);
            for (var i = 1; i < elementsNumber; i++)
            {
                if (i % 2 == 0 && i % 3 == 0)
                {
                    Assert.AreEqual(true, crossSet.ElementContains(i));
                }
            }
        }
    }
}
