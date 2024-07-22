namespace CountingVowels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // For context: emulating the game Scrabble
            // Emuluating key values pairs like with scrabble is typically done with a dictionary in C#

            // Our goal is to write a C# function that takes in a string (word or sentence)
            // Points will be assigned based on each vowel and how many times it appears

            // The function will return a string input and return a total score as an integer

            // The scoring criteria will be as follows: a = 1, e = 2, i = 3, o = 4, u = 5, y = 9;
            Console.WriteLine("Insert you're word:");
            string input = Console.ReadLine();
            Console.WriteLine($"The value of your word is: {WordValue2(input)}");

        }

        public static int WordValue(string  word)
        {
            int a = 1;
            int e = 2;
            int i = 3;
            int o = 4;
            int u = 5;
            int y = 9;
            int totalCount = 0;
            foreach (char c in word)
            {
                if(c == 'a')
                {
                    totalCount += a;
                }
                if(c == 'e')
                {
                    totalCount += e;
                }
                if(c == 'i')
                {
                    totalCount += i;
                }
                if(c == 'o')
                {
                    totalCount += o;
                }
                if(c == 'u')
                {
                    totalCount += u;
                }
                if(c == 'y')
                {
                    totalCount += y;
                }
            }
            return totalCount;
        }

        public static int WordValue2(string word)
        {
            Dictionary<char, int> vowels = new Dictionary<char, int>();
            int totalCount = 0;

            vowels.Add('a', 1);
            vowels.Add('e', 2);
            vowels.Add('i', 3);
            vowels.Add('o', 4);
            vowels.Add('u', 5);
            vowels.Add('y', 9);

            foreach(char c in word)
            {
                if(vowels.ContainsKey(c))
                {
                    totalCount += vowels[c];
                }
            }
            return totalCount;


        }
    }
}
