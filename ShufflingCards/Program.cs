using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Linq;
using System.Text.RegularExpressions;

namespace ShufflingCards
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> list = new List<string>();
            string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            string[] suits = { "\u2665", "\u2666", "\u2663", "\u2660" };

            string newListItem = "";
            
            for(int i = 0; i < ranks.Length; i++)
            {
                newListItem += ranks[i];
                for(int j = 0; j < suits.Length; j++)
                {
                    newListItem += suits[j];
                    list.Add(newListItem);
                    newListItem = ranks[i];

                    if(j == 3)
                    {
                        newListItem = "";
                    }
                }
            }


            Console.OutputEncoding = System.Text.Encoding.Unicode;

            foreach (string s in list)
            {
                Console.WriteLine(s);
            }

            List<string> shuffledDeck = new List<string>();
            shuffledDeck = DeckShuffler.shuffleThatDeck(list);
            
            Console.WriteLine();
            Console.WriteLine("Blind All-In! Let's Play!");
            Console.WriteLine("ENTER 1 to play.");
            Console.WriteLine("If you can't stand the heat then ENTER 2 and get out the kitchen!");
            string userInput = Console.ReadLine();
            string[] holdemCards = new string[2];

            
            try
            {
                if (userInput == "1")
                {
                    for (int i = 0; i < holdemCards.Length; i++)
                    {
                        holdemCards[i] = shuffledDeck[i];
                        Console.WriteLine(holdemCards[i]);
                    }

                    string cardOuput = "";
                    foreach(string s in holdemCards)
                    {
                        cardOuput += s;
                    }


                    Regex pairPattern = new Regex(@"(10|[2-9AKQJ])\1?");

                    // TODO This Regex is off, need to fix.
                    Regex acePattern = new Regex(@"(KA)");
                    if(pairPattern.IsMatch(cardOuput))
                    {
                        Console.WriteLine("You've got a pair. Not terrible");
                    }
                    return;
                }
                if (userInput == "2")
                {
                    return;
                }
                else
                {
                    throw new ArgumentException("Please press 1 to play or 2 to exit the program because you are a wimp");
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                DeckShuffler.cardHandler(holdemCards, shuffledDeck); 
            }

        }
        
        public class DeckShuffler
        {
            public static List<string> shuffleThatDeck(List<string> list)
            {
                Random randomizer = new Random();
                var shuffled = list.OrderBy(p => randomizer.Next()).ToList();
                return shuffled;
            }

            public static void cardHandler(string[] holdemCardsForThisMethod, List<string> shuffledDeckForThisMethod)
            {
                string userInputForThisMethod = Console.ReadLine();
                try
                {
                    if (userInputForThisMethod == "1")
                    {
                        for (int i = 0; i < holdemCardsForThisMethod.Length; i++)
                        {
                            holdemCardsForThisMethod[i] = shuffledDeckForThisMethod[i];
                            Console.WriteLine(holdemCardsForThisMethod[i]);
                        }

                        // I want to print out a message based on the output of my cards
                        // I think we should print the cards to a string so we can compare
                        string cardOuput = "";
                        foreach (string s in holdemCardsForThisMethod)
                        {
                            cardOuput += s;
                        }
                        // To do Regex, we need to include the Regex class in our namespace
                        Regex pairPattern = new Regex(@"([2-9AKQJ])\1");
                        Regex pairPatternTen = new Regex(@"(10)/1"); // Thought about doing this, but we can actually just put it into our original regex pattern 
                        Regex acePattern = new Regex(@"(A% | %A)");
                        Regex kingPattern = new Regex(@"(K% | %K)");

                        // TODO Need to implement the King or Ace Pattern
                        if (pairPattern.IsMatch(cardOuput)) // Tried to use Matches here, didn't work. Why?
                        {
                            Console.WriteLine("You've got a pair. Not terrible");
                            return;
                        }
                    }
                    if (userInputForThisMethod == "2")
                    {
                        return;
                    }
                    else
                    {
                        throw new ArgumentException("Please press 1 to play or 2 to exit the program because you are a wimp");
                    }
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                    cardHandler(holdemCardsForThisMethod, shuffledDeckForThisMethod);
                    

                }
                return;
            }
        }
        


    }
}
