namespace TipCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task is to  write a function that returns 3 different tip percentages for a meal.
            // Returns all three values in a single variable - returning a List is the first thing that comes to mind...

            // Function will take in the meal cost as an integer (I really feel like this should be a double)
            // Return all three list percentages as a single type (Again, this screams a List).

            // The tips for this challenge will be 10%, 17.5%, and 25%
            // Each tip needs to be rounded to two decimal places, which would be the nearest penny.
            double tipPlease = 0;
            bool validInput = false;
            // This wasnn't in the problem, but I think it would be nice to not only return the tip percentage but also return the total amount after the tip is added.
            
            while(!validInput)
            {
                Console.WriteLine("How much was your meal?  (Format: 00.00)");

                try
                {
                    tipPlease = double.Parse(Console.ReadLine());
                    validInput = true;
                    TipAmount(tipPlease);

                }
                catch (FormatException)
                {
                    // Theres's all different types of exceptions that need to be  thrown, so as a .NET C3 developer, its important to be aware of these 
                    Console.WriteLine("Please enter a valid meal price in the format of 00.00");
                }
            }



            // Now is a great time to implement exception handling for when a user doesn't enter a double value rounded to two decimals.

        }

        public static void TipAmount(double mealCost)
        {
            double[] tips = new double[] {.10,.175, .25};
            List<double> results = new List<double>();
            foreach(double tipAmount in tips)
            {
                double tip = Math.Round(mealCost * tipAmount,2);
                Console.WriteLine($"{Math.Round((tipAmount * 100), 2)}% Tip -> {tip}\nNew Total = {mealCost + tip}");
            }
            
        }
    }
}
