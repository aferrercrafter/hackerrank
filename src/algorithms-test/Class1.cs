using codewars.kyu_5;
using NUnit.Framework;
using System;
using System.Linq;

namespace algorithms_test
{
    public class codewars_test
    {
        private DotsBoxValidator _dotsAndBoxValidator;

        private static string[] Examples =
    {
        "{{0,1},{7,8},{1,2},{6,7},{0,3},{5,8},{3,4},{1,4},{4,5},{2,5},{4,7},{3,6}} -> 3,1",
        "{{0,1},{1,2},{2,5},{5,4},{4,7},{7,8},{8,5},{1,4},{6,7},{3,6},{3,0},{3,4}} -> 2,2",
        "{{0,1},{7,8},{1,2},{6,7},{0,3},{8,5},{3,4},{4,1},{4,5},{2,5},{3,6},{7,4}} -> 1,3",
        "{{0,1},{5,9},{9,8},{13,9},{7,11},{0,4},{9,10},{10,6},{4,5},{2,3},{13,14},{4,8},{8,12},{1,5},{5,6},{14,15},{10,11},{2,6},{12,13},{1,2},{10,14},{15,11},{6,7},{3,7}} -> 2,7",
        "{{5,9},{6,10},{9,13},{7,11},{4,5},{5,6},{6,7},{8,12},{1,5},{2,6},{8,9},{10,14},{10,11},{4,8},{12,13},{9,10},{1,2},{11,15},{13,14},{14,15},{0,4},{0,1},{3,7},{2,3}} -> 6,3"
    };

        private static int[] convrt(string s) => s.Split(',').Select(v => Int32.Parse(v)).ToArray();

        [SetUp]
        public void Setup()
        {
            _dotsAndBoxValidator = new DotsBoxValidator();
        }

        [Test, Description("5 Example Tests"), TestCaseSource("Examples")]
        public void TestDotsAndBoxValidator(string s)
        {
            var ssp = s.Split(" -> ");
            int[][] inp = ssp[0].Substring(2, ssp[0].Length - 4).Split("},{", StringSplitOptions.RemoveEmptyEntries).Select(e => convrt(e)).ToArray();
            int[] sol = convrt(ssp[1]);
            Assert.That(_dotsAndBoxValidator.DotsAndBoxes(inp), Is.EqualTo(sol));
        }

    }
}
