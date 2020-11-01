using codility;
using codility.array_rotation;
using NUnit.Framework;

namespace algorithms_test
{
    public class Tests
    {
        private BinaryGap _binaryGap;
        private ArrayRotation _arrayRotation;

        [SetUp]
        public void Setup()
        {
            _binaryGap = new BinaryGap();
            _arrayRotation = new ArrayRotation();
        }

        [Test]
        public void TestBynaryGap()
        {
            int s = _binaryGap.Solution(1041);
            Assert.AreEqual(5, s);

            s = _binaryGap.Solution(15);
            Assert.AreEqual(0, s);

            s = _binaryGap.Solution(32);
            Assert.AreEqual(0, s);
        }

        [Test]
        public void TestArrayRotration()
        {
            int[] s = _arrayRotation.Solution(new int []{ 3, 8, 9, 7, 6 }, 3);
            Assert.That(new int[] { 9, 7, 6, 3, 8 }, Is.EqualTo(s));

            s = _arrayRotation.Solution(new int[] { 0,0,0 }, 1);
            Assert.That(new int[] { 0, 0, 0 }, Is.EqualTo(s));

            s = _arrayRotation.Solution(new int[] { 1, 2, 3, 4 }, 4);
            Assert.That(new int[] { 1, 2, 3, 4}, Is.EqualTo(s));
        }
    }
}