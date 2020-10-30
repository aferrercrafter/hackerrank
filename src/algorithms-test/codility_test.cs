using codility;
using codility.array_rotation;
using codility.frog_jump;
using codility.perm_missing_element;
using codility.unpaired_elements;
using NUnit.Framework;

namespace algorithms_test
{
    public class Tests
    {
        private BinaryGap _binaryGap;
        private ArrayRotation _arrayRotation;
        private UnpairedElements _unpairedElements;
        private FrogJump _frogJump;
        private PermMissingElement _permMissingElement;

        [SetUp]
        public void Setup()
        {
            _binaryGap = new BinaryGap();
            _arrayRotation = new ArrayRotation();
            _unpairedElements = new UnpairedElements();
            _frogJump = new FrogJump();
            _permMissingElement = new PermMissingElement();
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

        [Test]
        public void TestUnpairedElements()
        {
            int s = _unpairedElements.Solution(new int[] { 9, 3, 9, 3, 9 ,7, 9});
            Assert.AreEqual(7, s);

            s = _unpairedElements.Solution(new int[] { 9, 3, 9, 3, 9, 7, 7 });
            Assert.AreEqual(9, s);
        }

        [Test]
        public void TestFrogJump()
        {
            int s = _frogJump.Solution(10, 85, 30);
            Assert.AreEqual(3, s);
        }

        [Test]
        public void TestPermMissingElement()
        {
            int s = _permMissingElement.Solution(new int[] { 2, 3, 1, 5 });
            Assert.AreEqual(4, s);
        }
    }
}