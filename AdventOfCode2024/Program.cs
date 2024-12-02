namespace AdventOfCode2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var computeur = new AdventOfCode();
            Console.WriteLine("Day 1 A => " + computeur.Day1Compute());
            Console.WriteLine("Day 1 B => " + computeur.Day1BCompute());
            Console.WriteLine("Day 2 => " + computeur.Day2Compute());
        }
    }
}
