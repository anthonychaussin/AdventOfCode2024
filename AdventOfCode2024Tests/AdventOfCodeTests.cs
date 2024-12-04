using AdventOfCode2024;

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

        [TestMethod()]
        [DataRow(@"....XXMAS.
.SAMXMS...
...S..A...
..A.A.MS.X
XMASAMX.MM
X.....XA.A
S.S.S.S.SS
.A.A.A.A.A
..M.M.M.MM
.X.X.XMASX", 5)]
        [DataRow(@"MMMSXXMASM
MSAMXMSMSA
AMXSXMAAMM
MSAMASMSMX
XMASAMXAMM
XXAMMXXAMA
SMSMSASXSS
SAXAMASAAA
MAMMMXMMMM
MXMXAXMASX", 5)]
        public void BasicCountTest(string input, int expectedLine)
        {
            Assert.AreEqual(expectedLine, Day4.BasicCount(input));
        }


        [TestMethod()]
        [DataRow(@"....XXMAS.
.SAMXMS...
...S..A...
..A.A.MS.X
XMASAMX.MM
X.....XA.A
S.S.S.S.SS
.A.A.A.A.A
..M.M.M.MM
.X.X.XMASX", 3)]
        [DataRow(@"MMMSXXMASM
MSAMXMSMSA
AMXSXMAAMM
MSAMASMSMX
XMASAMXAMM
XXAMMXXAMA
SMSMSASXSS
SAXAMASAAA
MAMMMXMMMM
MXMXAXMASX", 3)]
        public void VerticalCountTest(string input, int expectedColonnes)
        {
            Assert.AreEqual(expectedColonnes, Day4.VerticalCount(input));
        }

    
        [TestMethod()]
        [DataRow(@"....XXMAS.
.SAMXMS...
...S..A...
..A.A.MS.X
XMASAMX.MM
X.....XA.A
S.S.S.S.SS
.A.A.A.A.A
..M.M.M.MM
.X.X.XMASX", 5)]
        [DataRow(@"MMMSXXMASM
MSAMXMSMSA
AMXSXMAAMM
MSAMASMSMX
XMASAMXAMM
XXAMMXXAMA
SMSMSASXSS
SAXAMASAAA
MAMMMXMMMM
MXMXAXMASX", 5)]
        public void DiagRCountTest(string input, int expectedDiagR)
        {
            Assert.AreEqual(expectedDiagR, Day4.DiagonalRCount(input));
        }

        [TestMethod()]
        [DataRow(@"....XXMAS.
.SAMXMS...
...S..A...
..A.A.MS.X
XMASAMX.MM
X.....XA.A
S.S.S.S.SS
.A.A.A.A.A
..M.M.M.MM
.X.X.XMASX", 5)]
        [DataRow(@"MMMSXXMASM
MSAMXMSMSA
AMXSXMAAMM
MSAMASMSMX
XMASAMXAMM
XXAMMXXAMA
SMSMSASXSS
SAXAMASAAA
MAMMMXMMMM
MXMXAXMASX", 5)]
        public void DiagLCountTest(string input, int expectedDiagL)
        {
            Assert.AreEqual(expectedDiagL, Day4.DiagonalLCount(input));
        }

        [TestMethod()]
        [DataRow(@"....XXMAS.
.SAMXMS...
...S..A...
..A.A.MS.X
XMASAMX.MM
X.....XA.A
S.S.S.S.SS
.A.A.A.A.A
..M.M.M.MM
.X.X.XMASX", 18)]
        [DataRow(@"MMMSXXMASM
MSAMXMSMSA
AMXSXMAAMM
MSAMASMSMX
XMASAMXAMM
XXAMMXXAMA
SMSMSASXSS
SAXAMASAAA
MAMMMXMMMM
MXMXAXMASX", 18)]
        public void WordFinderTest(string input, int expected)
        {
            Assert.AreEqual(expected, Day4.TotalCount(input));
        }

        [TestMethod()]
        [DataRow(@".M.S......
..A..MSMS.
.M.S.MAA..
..A.ASMSM.
.M.S.M....
..........
S.S.S.S.S.
.A.A.A.A..
M.M.M.M.M.
..........", 9)]
        [DataRow(@"MMMSXXMASM
MSAMXMSMSA
AMXSXMAAMM
MSAMASMSMX
XMASAMXAMM
XXAMMXXAMA
SMSMSASXSS
SAXAMASAAA
MAMMMXMMMM
MXMXAXMASX", 9)]
        public void CrossFinderTest(string input, int expected)
        {
            Assert.AreEqual(expected, Day4.CrossCount(input));
        }

    }
}

