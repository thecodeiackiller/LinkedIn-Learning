namespace CalculatingStats
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a C# function that takes in a list of scores
            // 1. Calculate the highest and lowest values
            // 2. Calculate the sum and average of all the scores
            // Print these values out to the console

            // Method will have an input of list of integers
            // It won't have a return value

            
            int[] sznStats = new int[] { 2100, 1879, 1234, 2132, 2005, 2111, 1977, 1709 };
            StatCalculations(sznStats);
        }
        static void StatCalculations(int[] statsSeason)
        {
            List<int> stats = new List<int>();  
            foreach (int i in statsSeason)
            {
                stats.Add(i);
            }

            Console.WriteLine($"Max Points:{stats.Max()}");
            Console.WriteLine($"Min Points: {stats.Min()}");
            Console.WriteLine($"Average Points: {stats.Average()}");
            Console.WriteLine($"Total Points: {stats.Sum()}");
        }
    }
}
