using System;
using NUnit.Framework;

namespace NUnit
{
    [TestFixture]
    public class NUnitExample
    {
        [Test]
        public void TestThatPasses()
        {
            Assert.IsTrue(true);
        }
    }
}
