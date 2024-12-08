namespace AdventOfCode2024
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var computeur = new AdventOfCode();
            Console.WriteLine("Day 1 A => " + computeur.Day1Compute());
            Console.WriteLine("Day 1 B => " + computeur.Day1BCompute());
            Console.WriteLine("Day 2 => " + computeur.Day2Compute());
            Console.WriteLine("Day 3 A => " + computeur.Day3Compute());
            Console.WriteLine("Day 3 B => " + computeur.Day3BCompute());
            Console.WriteLine("Day 4 A => " + computeur.Day4Compute());
            Console.WriteLine("Day 4 B => " + computeur.Day4BCompute());
            Console.WriteLine("Day 5 A => " + computeur.Day5Compute());
            Console.WriteLine("Day 5 B => " + computeur.Day5BCompute());
            //Console.WriteLine("Day 6 => " + computeur.Day6Compute());
            Console.WriteLine("Day 7 A => " + computeur.Day7Compute());
            Console.WriteLine("Day 7 B => " + computeur.Day7BCompute());
        }
    }
}