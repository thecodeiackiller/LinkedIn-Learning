using System.Reflection;
using static CarDealer.Factory;

namespace CarDealer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // MARK: Setup
            Console.WriteLine("Hit ENTER to find the vehicles you're looking for!");
            Console.ReadKey();

            // MARK: Result
            GetModels();
            Console.ReadKey();
        }

        // MARK: Write your solution here...
        public static void GetModels()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var types = assembly.GetTypes();

            var abstractTypes = types.Where(t => t.IsSubclassOf(typeof(Car)) && !t.IsAbstract).ToList();

            foreach (var type in abstractTypes)
            {
                Console.WriteLine(type.Name);
            }

        }
    }
}
