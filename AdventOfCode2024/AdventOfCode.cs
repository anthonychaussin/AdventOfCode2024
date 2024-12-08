using System.Collections.Concurrent;

namespace AdventOfCode2024
{
    public class AdventOfCode
    {
        public int Day1Compute()
        {
            var lists = new Day1().Data;
            return Day1.Distance(lists.First(), lists.Last());
        }

        public int Day1BCompute()
        {
            var lists = new Day1().Data;
            return Day1.Similiarity(lists.First().Order().ToList(), lists.Last().Order().ToList());
        }

        public int Day2Compute()
        {
            var ints = new Day2().Data;
            var results = new ConcurrentBag<bool>();
            var taskList = new List<Task>();

            foreach (var item in ints)
            {
                taskList.Add(Task.Run(() =>
                {
                    results.Add(Day2.IsSafe(item));
                }));
            }

            Task.WaitAll([.. taskList]);
            return results.Count(e => e);
        }

        public int Day3Compute()
        {
            var input = new Day3().Data;
            return Day3.Multiply(input);
        }

        public int Day3BCompute()
        {
            var input = new Day3().Data;
            return Day3.Multiply2(input);
        }

        public int Day4Compute()
        {
            var input = new Day4().Data;
            return Day4.TotalCount(input);
        }

        public int Day4BCompute()
        {
            var input = new Day4().Data;
            return Day4.CrossCount(input);
        }

        public int Day5Compute()
        {
            var day5 = new Day5();
            return Day5.CheckGoodUpdates(day5.Updates, day5.Rules);
        }

        public int Day5BCompute()
        {
            var day5 = new Day5();
            return Day5.CheckBadUpdates(day5.Updates, day5.Rules);
        }

        public int Day6Compute()
        {
            var day6 = new Day6();
            day6.Play();
            return day6.GetResult();
        }

        public long Day7Compute()
        {
            var day = new Day7();
            return Day7.FindAllPossibilities(day.Equations).Sum();
        }

        public long Day7BCompute()
        {
            var day = new Day7();
            return Day7.FindAllPossibilities2(day.Equations).Sum();
        }
    }
}