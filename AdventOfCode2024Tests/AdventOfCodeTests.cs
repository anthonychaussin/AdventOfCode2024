namespace AdventOfCode2024.Tests
{
    [TestClass()]
    public class AdventOfCodeTests
    {
        [TestMethod()]
        [DataRow(new int[] { 7, 6, 4, 2, 1 }, true)]
        [DataRow(new int[] { 1, 2, 7, 8, 9 }, false)]
        [DataRow(new int[] { 9, 7, 6, 2, 1 }, false)]
        [DataRow(new int[] { 1, 3, 2, 4, 5 }, true)]
        [DataRow(new int[] { 8, 6, 4, 4, 1 }, true)]
        [DataRow(new int[] { 1, 3, 6, 7, 9 }, true)]
        [DataRow(new int[] { 5, 6, 7, 10, 13, 16, 13 }, true)]
        [DataRow(new int[] { 16, 18, 20, 21, 23, 25, 29 }, true)]
        public void IsSafeTest(int[] values, bool expected)
        {
            Assert.AreEqual(expected, Day2.IsSafe(values.ToList()));
        }

        [TestMethod()]
        [DataRow(new int[] { 3, 4, 2, 1, 3, 3 }, new int[] { 4, 3, 5, 3, 9, 3 }, 11)]
        public void ComputeDistanceTest(int[] first, int[] second, int expected)
        {
            Assert.AreEqual(expected, Day1.Distance(first.ToList(), second.ToList()));
        }


        [TestMethod()]
        [DataRow(new int[] { 3, 4, 2, 1, 3, 3 }, new int[] { 4, 3, 5, 3, 9, 3 }, 31)]
        public void ComputeSimilarityTest(int[] first, int[] second, int expected)
        {
            Assert.AreEqual(expected, Day1.Similiarity(first.ToList(), second.ToList()));
        }


        [TestMethod()]
        [DataRow(@"xmul(2,4)%&mul[3,7]!@^do_not_mul(5,5)+mul(32,64]then(mul(11,8)mul(8,5))", 161)]
        public void ComputeMulTest(string input, int expected)
        {
            Assert.AreEqual(expected, Day3.Multiply(input));
        }

        [TestMethod()]
        [DataRow(@"xmul(2,4)&mul[3,7]!^don't()_mul(5,5)+mul(32,64](mul(11,8)undo()?mul(8,5))", 48)]
        public void ComputeMulTest2(string input, int expected)
        {
            Assert.AreEqual(expected, Day3.Multiply2(input));
        }
    }
}