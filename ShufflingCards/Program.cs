using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace ShufflingCards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Need a function that randomly shuffles a deck of cards objects

            // INPUT Function will take in a list of strings, each string representing a card
            // OUTPUT Return a randomly shuffled list of those same cards


            // EXTRA CREDIT: Deal out a random hand as if were playing Texas Hold'em

            List<string> list = new List<string>();
            string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" }; // The 10 was causing me trouble here - needed to be an array of strings

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
            // NOTE: This is cool, but we really have to take into account Big O notation here. Obviously, our time complexity is not great here with a nested for loop.
            // QUESTION: How do we remove a layer of complexity from our time and/or space complexity?
            // QUESTION: How can we actually see the difference between the space and time complexity within our IDE?


            Console.OutputEncoding = System.Text.Encoding.Unicode;

            foreach (string s in list)
            {
                Console.WriteLine(s);
            }
            // TO-DO Now, we want to actually randomize our list into a new list.
            // NOTE: I'm thinking that we create a "shuffledList" List of strings

            List<string> shuffledDeck = new List<string>();
            shuffledDeck = DeckShuffler.shuffleThatDeck(list);

            //foreach(string s in shuffledDeck)
            //{
            //    Console.WriteLine(s);
            //}

            Console.WriteLine("Blind All-In! Do you want to play? I hope you get good cards");
            Console.WriteLine("To play, ENTER 1");
            Console.WriteLine("To sit on the sidelines like a wimp and exit the program");
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

                }
                if (userInput == "2")
                {
                    
                }
            }
            catch
            {
                throw new ArgumentException("Please press 1 to play or 2 to exit the program because you are a wimp");
            }

        }
        
        public class DeckShuffler
        {
            public static List<string> shuffleThatDeck(List<string> list)
            {
                Random randomizer = new Random();
                var shuffled = list.OrderBy(p => randomizer.Next()).ToList(); // What did I try to do here?
                return shuffled;
            }
        }
        


    }
}
