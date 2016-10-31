using System;

namespace NUnit
{
    [TestFixture]
    public class UnitTest1
    {
        [TestMethod]
        public void TestThatPasses()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void TestThatFails()
        {
            Assert.Fail("This test is supposed to fail");
        }
    }
}
