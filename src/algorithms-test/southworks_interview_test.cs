using interviews.southworks_codility;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace algorithms_test
{
    public class southworks_interview_test
    {
        private DaysPermutation _daysPermutation;
        private LexicographicallySmallestWord _lexicographicallySmallestWord;
        private BinaryPeriod _binaryPeriod;

        [SetUp]
        public void Setup()
        {
            _daysPermutation = new DaysPermutation();
            _lexicographicallySmallestWord = new LexicographicallySmallestWord();
            _binaryPeriod = new BinaryPeriod();
        }

        [Test]
        public void TestDaysPermutation()
        {
            string s = _daysPermutation.Solution("Wed", 2);
            Assert.AreEqual("Fri", s);

            s = _daysPermutation.Solution("Sat", 23);
            Assert.AreEqual("Mon", s);

            s = _daysPermutation.Solution("Sat", 0);
            Assert.AreEqual("Sat", s);
        }

        [Test]
        public void TestLexicographicallySmallestWord()
        {
            string s = _lexicographicallySmallestWord.Solution("acb");
            Assert.AreEqual("ab", s);

            s = _lexicographicallySmallestWord.Solution("hot");
            Assert.AreEqual("ho", s);

            s = _lexicographicallySmallestWord.Solution("codility");
            Assert.AreEqual("cdility", s);

            s = _lexicographicallySmallestWord.Solution("aaaa");
            Assert.AreEqual("aaa", s);

            s = _lexicographicallySmallestWord.Solution("cadility");
            Assert.AreEqual("adility", s);

            s = _lexicographicallySmallestWord.Solution("ccdility");
            Assert.AreEqual("ccdiity", s);

            s = _lexicographicallySmallestWord.Solution("aa");
            Assert.AreEqual("a", s);
        }

        [Test]
        public void TestBinaryPeriod()
        {
            int s = _binaryPeriod.Solution(955);
            Assert.AreEqual(4, s);

            s = _binaryPeriod.Solution(8);
            Assert.AreEqual(-1, s);
        }

    }
}
