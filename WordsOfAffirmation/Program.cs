using System.Timers;
using System.Collections.Generic;


namespace WordsOfAffirmation
{
    internal class Program
    {
        static Random random = new Random();
        static List<string> encouragements = new List<string>()
        {
            "Way to go!",
            "Keep it up!",
            "Almost there!",
            "You're doing great!"
        };

        // 1
        static System.Timers.Timer timer;


        static void Main(string[] args)
        {
            // Goal for this project is to create a C# program with a repeating timer

            // Input value of method is going to be time in seconds as an integer value
            // Output will be random phrase printed at set interval

            // So if we passed in 5 to the method, we would expect a renadom phrase to be printed to the console every 5 seconds


            // We'll act like the person working out is going through a 30 second workout just for example purposes
            // Going to go a step furhter than what the problem is and create custom messages based on a trainees name

            // MARK: Setup
            Console.WriteLine("Hit ENTER to start the timer!");
            Console.ReadLine();

            // MARK: Result
            StartTimer(3);

            Console.WriteLine("You can end the timer anytime by pressing ENTER.\n");
            Console.ReadLine();
            StopTimer();

        }

        public static void StartTimer(int interval)
        {
            // 2
            int milliseconds = interval * 1000;
            timer = new System.Timers.Timer(milliseconds);

            // 3
            timer.Elapsed += OnTimerEvent;

            // 4
            timer.AutoReset = true;
            timer.Enabled = true;
        }

        // 5
        private static void OnTimerEvent(Object source, ElapsedEventArgs e)
        {
            int index = random.Next(4);
            Console.WriteLine(encouragements[index]);
        }

        // 6
        public static void StopTimer()
        {
            timer.Stop();
            timer.Dispose();
            Console.WriteLine("Time stopped");
        }
    }
}
