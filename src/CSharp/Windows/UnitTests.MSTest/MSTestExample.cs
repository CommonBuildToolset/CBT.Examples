using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTest
{
    [TestClass]
    public class MSTestExample
    {
        [TestMethod]
        public void TestThatPasses()
        {
            Assert.IsTrue(true);
        }
    }
}
