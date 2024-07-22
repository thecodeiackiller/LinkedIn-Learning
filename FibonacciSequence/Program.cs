namespace FibonacciSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a C# function with a given timer
            // Calculates the fibonacci sequence of a given length

            // The method takes in an integer value taking in the length of the length of the a list of fibacci numbers we want
            // The method outputs a list of integer values representing subsequent fibonacci numbers with the length of the input integer parameter.

            // Critera - for this example, the first two numbers must always be 0 and 1
            // Each Fibonacci number is the sum of the two previous numbers 
            // For example, method(5) would produce this string: {0,1,1,2,3}
            Console.WriteLine("Press ENTER to see the next number in the fibonacci sequence:");
            Console.ReadLine();
            Fibonacci.CalculateFibonacci(20);
        }
    }
}
