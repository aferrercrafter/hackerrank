using codility;
using NUnit.Framework;

namespace algorithms_test
{
    public class Tests
    {
        private BinaryGap _binaryGap;

        [SetUp]
        public void Setup()
        {
            _binaryGap = new BinaryGap();
        }

        [Test]
        public void TestBynary_Gap()
        {
            int s = _binaryGap.Solution(1041);
            Assert.AreEqual(5, s);

            s = _binaryGap.Solution(15);
            Assert.AreEqual(0, s);

            s = _binaryGap.Solution(32);
            Assert.AreEqual(0, s);
        }
    }
}