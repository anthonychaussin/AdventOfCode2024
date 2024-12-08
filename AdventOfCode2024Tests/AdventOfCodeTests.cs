using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode2024;

namespace AdventOfCode2024.Tests
{
    [TestClass()]
    public class AdventOfCodeTests
    {
        [TestMethod("Day2 - IsSafeTest")]
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

        [TestMethod("Day1 - ComputeDistanceTest")]
        [DataRow(new int[] { 3, 4, 2, 1, 3, 3 }, new int[] { 4, 3, 5, 3, 9, 3 }, 11)]
        public void ComputeDistanceTest(int[] first, int[] second, int expected)
        {
            Assert.AreEqual(expected, Day1.Distance(first.ToList(), second.ToList()));
        }


        [TestMethod("Day1 - ComputeSimilarityTest")]
        [DataRow(new int[] { 3, 4, 2, 1, 3, 3 }, new int[] { 4, 3, 5, 3, 9, 3 }, 31)]
        public void ComputeSimilarityTest(int[] first, int[] second, int expected)
        {
            Assert.AreEqual(expected, Day1.Similiarity(first.ToList(), second.ToList()));
        }


        [TestMethod("Day3 - ComputeMulTest")]
        [DataRow(@"xmul(2,4)%&mul[3,7]!@^do_not_mul(5,5)+mul(32,64]then(mul(11,8)mul(8,5))", 161)]
        public void ComputeMulTest(string input, int expected)
        {
            Assert.AreEqual(expected, Day3.Multiply(input));
        }

        [TestMethod("Day3 - ComputeMulTest2")]
        [DataRow(@"xmul(2,4)&mul[3,7]!^don't()_mul(5,5)+mul(32,64](mul(11,8)undo()?mul(8,5))", 48)]
        public void ComputeMulTest2(string input, int expected)
        {
            Assert.AreEqual(expected, Day3.Multiply2(input));
        }

        [TestMethod("Day4 - BasicCountTest")]
        [DataRow("....XXMAS.\r\n.SAMXMS...\r\n...S..A...\r\n..A.A.MS.X\r\nXMASAMX.MM\r\nX.....XA.A\r\nS.S.S.S.SS\r\n.A.A.A.A.A\r\n..M.M.M.MM\r\n.X.X.XMASX", 5)]
        [DataRow("MMMSXXMASM\r\nMSAMXMSMSA\r\nAMXSXMAAMM\r\nMSAMASMSMX\r\nXMASAMXAMM\r\nXXAMMXXAMA\r\nSMSMSASXSS\r\nSAXAMASAAA\r\nMAMMMXMMMM\r\nMXMXAXMASX", 5)]
        public void BasicCountTest(string input, int expectedLine)
        {
            Assert.AreEqual(expectedLine, Day4.BasicCount(input));
        }


        [TestMethod("Day4 - VerticalCountTest")]
        [DataRow("....XXMAS.\r\n.SAMXMS...\r\n...S..A...\r\n..A.A.MS.X\r\nXMASAMX.MM\r\nX.....XA.A\r\nS.S.S.S.SS\r\n.A.A.A.A.A\r\n..M.M.M.MM\r\n.X.X.XMASX", 3)]
        [DataRow("MMMSXXMASM\r\nMSAMXMSMSA\r\nAMXSXMAAMM\r\nMSAMASMSMX\r\nXMASAMXAMM\r\nXXAMMXXAMA\r\nSMSMSASXSS\r\nSAXAMASAAA\r\nMAMMMXMMMM\r\nMXMXAXMASX", 3)]
        public void VerticalCountTest(string input, int expectedColonnes)
        {
            Assert.AreEqual(expectedColonnes, Day4.VerticalCount(input));
        }


        [TestMethod("Day4 - DiagRCountTest")]
        [DataRow("....XXMAS.\r\n.SAMXMS...\r\n...S..A...\r\n..A.A.MS.X\r\nXMASAMX.MM\r\nX.....XA.A\r\nS.S.S.S.SS\r\n.A.A.A.A.A\r\n..M.M.M.MM\r\n.X.X.XMASX", 5)]
        [DataRow("MMMSXXMASM\r\nMSAMXMSMSA\r\nAMXSXMAAMM\r\nMSAMASMSMX\r\nXMASAMXAMM\r\nXXAMMXXAMA\r\nSMSMSASXSS\r\nSAXAMASAAA\r\nMAMMMXMMMM\r\nMXMXAXMASX", 5)]
        public void DiagRCountTest(string input, int expectedDiagR)
        {
            Assert.AreEqual(expectedDiagR, Day4.DiagonalRCount(input));
        }

        [TestMethod("Day4 - DiagLCountTest")]
        [DataRow("....XXMAS.\r\n.SAMXMS...\r\n...S..A...\r\n..A.A.MS.X\r\nXMASAMX.MM\r\nX.....XA.A\r\nS.S.S.S.SS\r\n.A.A.A.A.A\r\n..M.M.M.MM\r\n.X.X.XMASX", 5)]
        [DataRow("MMMSXXMASM\r\nMSAMXMSMSA\r\nAMXSXMAAMM\r\nMSAMASMSMX\r\nXMASAMXAMM\r\nXXAMMXXAMA\r\nSMSMSASXSS\r\nSAXAMASAAA\r\nMAMMMXMMMM\r\nMXMXAXMASX", 5)]
        public void DiagLCountTest(string input, int expectedDiagL)
        {
            Assert.AreEqual(expectedDiagL, Day4.DiagonalLCount(input));
        }

        [TestMethod("Day4 - WordFinderTest")]
        [DataRow("....XXMAS.\r\n.SAMXMS...\r\n...S..A...\r\n..A.A.MS.X\r\nXMASAMX.MM\r\nX.....XA.A\r\nS.S.S.S.SS\r\n.A.A.A.A.A\r\n..M.M.M.MM\r\n.X.X.XMASX", 18)]
        [DataRow("MMMSXXMASM\r\nMSAMXMSMSA\r\nAMXSXMAAMM\r\nMSAMASMSMX\r\nXMASAMXAMM\r\nXXAMMXXAMA\r\nSMSMSASXSS\r\nSAXAMASAAA\r\nMAMMMXMMMM\r\nMXMXAXMASX", 18)]
        public void WordFinderTest(string input, int expected)
        {
            Assert.AreEqual(expected, Day4.TotalCount(input));
        }

        [TestMethod("Day4 - CrossFinderTest")]
        [DataRow(".M.S......\r\n..A..MSMS.\r\n.M.S.MAA..\r\n..A.ASMSM.\r\n.M.S.M....\r\n..........\r\nS.S.S.S.S.\r\n.A.A.A.A..\r\nM.M.M.M.M.\r\n..........", 9)]
        [DataRow("MMMSXXMASM\r\nMSAMXMSMSA\r\nAMXSXMAAMM\r\nMSAMASMSMX\r\nXMASAMXAMM\r\nXXAMMXXAMA\r\nSMSMSASXSS\r\nSAXAMASAAA\r\nMAMMMXMMMM\r\nMXMXAXMASX", 9)]
        public void CrossFinderTest(string input, int expected)
        {
            Assert.AreEqual(expected, Day4.CrossCount(input));
        }

        [TestMethod("Day5 - CheckGoodUpdates")]
        [DataRow("47|53\r\n97|13\r\n97|61\r\n97|47\r\n75|29\r\n61|13\r\n75|53\r\n29|13\r\n97|29\r\n53|29\r\n61|53\r\n97|53\r\n61|29\r\n47|13\r\n75|47\r\n97|75\r\n47|61\r\n75|61\r\n47|29\r\n75|13\r\n53|13"
            , "75,47,61,53,29\r\n97,61,53,29,13\r\n75,29,13\r\n75,97,47,61,53\r\n61,13,29\r\n97,13,75,29,47", 143)]
        public void Day5ComputeTest(string rules, string updates, int expected)
        {
            var day5 = new Day5(rules, updates);
            Assert.AreEqual(expected, Day5.CheckGoodUpdates(day5.Updates, day5.Rules));
        }

        [TestMethod("Day5 - CheckBadUpdates")]
        [DataRow("47|53\r\n97|13\r\n97|61\r\n97|47\r\n75|29\r\n61|13\r\n75|53\r\n29|13\r\n97|29\r\n53|29\r\n61|53\r\n97|53\r\n61|29\r\n47|13\r\n75|47\r\n97|75\r\n47|61\r\n75|61\r\n47|29\r\n75|13\r\n53|13"
            , "75,47,61,53,29\r\n97,61,53,29,13\r\n75,29,13\r\n75,97,47,61,53\r\n61,13,29\r\n97,13,75,29,47", 123)]
        public void Day5BadComputeTest(string rules, string updates, int expected)
        {
            var day5 = new Day5(rules, updates);
            Assert.AreEqual(expected, Day5.CheckBadUpdates(day5.Updates, day5.Rules));
        }

        [TestMethod("Day7 - FindAllPossibilitiesTest")]
        [DataRow("190: 10 19\r\n3267: 81 40 27\r\n83: 17 5\r\n156: 15 6\r\n7290: 6 8 6 15\r\n161011: 16 10 13\r\n192: 17 8 14\r\n21037: 9 7 18 13\r\n292: 11 6 16 20", 3749)]
        public void FindAllPossibilitiesTest(string input, long expected)
        {
            var day7 = new Day7() { data = input };
            Assert.AreEqual(expected, Day7.FindAllPossibilities(day7.Equations).Sum());
        }


        [TestMethod("Day7 B - FindAllPossibilitiesTest")]
        [DataRow("190: 10 19\r\n3267: 81 40 27\r\n83: 17 5\r\n156: 15 6\r\n7290: 6 8 6 15\r\n161011: 16 10 13\r\n192: 17 8 14\r\n21037: 9 7 18 13\r\n292: 11 6 16 20", 11387)]
        public void FindAllPossibilitiesTest2(string input, long expected)
        {
            var day7 = new Day7() { data = input };
            Assert.AreEqual(expected, Day7.FindAllPossibilities2(day7.Equations).Sum());
        }

    }
}

