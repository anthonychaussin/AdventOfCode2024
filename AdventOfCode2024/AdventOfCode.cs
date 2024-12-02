
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
    }
}
