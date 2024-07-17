using System.Diagnostics.SymbolStore;
using System.Text.RegularExpressions;

namespace EmailValidation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Method will input a string
            // Will need to output a message to the console for each failure case or success.

            // Email criteria: A valid email has to have 3 things:
            // 1. First character cannot have a symbol or a number
            // 2. Needs to be an @ sign
            // 3. Email must end with .com

            Console.WriteLine("Please enter your email:");
            string newEmail = Console.ReadLine();
            Program program = new Program();
            program.IsValidEmail(newEmail);

        }

        public void IsValidEmail(string email)
        {
            string firstLetterPattern = @"^[A-Za-z]";
            if (!email.Contains('@'))
            {
                Console.WriteLine("Please make sure you have an '@' symbol in your email");
                return;
            }
            else if (!email.EndsWith(".com"))
            {
                Console.WriteLine("Please make sure you have an email that ends with '.com'");
                return;
            }
            else if (!Regex.IsMatch(email, firstLetterPattern))
            {
                Console.WriteLine("Please make sure the first letter starts with a letter instead of a symbol or number");
                return;
            }
            Console.WriteLine("Congratulations, youre email has been verified!");
        }
    }
}
