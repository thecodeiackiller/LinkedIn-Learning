using System.Xml.Schema;

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
            List<int> list = new List<int>();

            for(int i = 1; i < 5; i++)
            {
                Console.WriteLine($"What was the overall season score for Player {i}");
                int input = int.Parse(Console.ReadLine());
                list.Add(input);
            }

            // StatCalculations(sznStats);
            printStats(list);
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

        public static void printStats(List<int> stats)
        {
            // 1
            stats.Sort();
            // By default, this sorts the list in ascending order 
            // We know, therefore, that the lowest score is first and the highest score is last

            // 2
            int lowestScore = stats[0];
            Console.WriteLine($"The lowest score is: {lowestScore} \n");

            // 3
            int highestScore = stats[stats.Count - 1];
            Console.WriteLine($"\n The highest score is \t-> {highestScore}");


            // 4
            int sum = 0;
            for(int i = 0; i < stats.Count; i++)
            {
                sum += stats[i];
            }
            Console.WriteLine($"\n The sum of all scores is \t -> {sum}");

            // 5
            int avg = 0;
            Console.WriteLine($"\n The average of all scores is \t -> {sum / stats.Count}");  
        }
    }
}
