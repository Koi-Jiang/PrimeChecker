using NUnit.Framework;
using PrimeChecker;

namespace NUnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(83)]
        [TestCase(101)]
        [TestCase(113)]
        public void TestTrue(int num)
        {
            Assert.IsTrue(Prime.Check(num));            
        }

        [Test]
        [TestCase(1)]
        [TestCase(-5)]
        [TestCase(8)]
        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(128)]
        [TestCase(1024)]
        [TestCase(187)]
        public void TestFalse(int num)
        {
            Assert.IsFalse(Prime.Check(num));
        }
    }
}