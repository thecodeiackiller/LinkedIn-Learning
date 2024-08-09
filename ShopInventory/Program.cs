using System.Net.Security;

namespace ShopInventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
           
            var grocery = new Shop();
            Console.WriteLine("Welcome to John's Grocery!");
            Console.WriteLine("Press 1 to Enter a New Item.");
            Console.WriteLine("Press 2 to Exit.");
            var userInput = Console.ReadLine();
            
            int dictionaryIndexKey = 0;


            while (userInput != "2") 
            {
                 // Question: Why do we have to move this above the while loop? 
                // Question: How would we have figured out the problem with this in the debugger?
                string dictionaryStringValue = "";
                // Best way to think of a switch case statement. An alternative is an if else, but we use switch case if we have a very small amount of options.
                // we are switching the logic depending on the case.
                // To the switch statement will contain a variable that has the ability to be changed
                // The case statements give all the possible, well, cases or possibilities for the particular variable.

                if (userInput == "1") 
                {
                    // How do I know if I've reached to point in my code where I have created an infinite loop?
                    // Check CPU
                    // Check Call Stack
                    Console.Write("Item Name: ");
                    dictionaryStringValue = Console.ReadLine();
                    grocery[dictionaryIndexKey] = dictionaryStringValue;
                    if(grocery.DuplicateItems(dictionaryStringValue) == false)
                    {
                        Console.WriteLine("Item Added!");
                    }
                    dictionaryIndexKey++;
                }

                

                Console.WriteLine("Press 1 to Enter a New Item.");
                Console.WriteLine("Press 2 to Exit.");
                userInput = Console.ReadLine();
            }

            
        }
    }
}
