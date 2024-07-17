using System.ComponentModel;

namespace DecomposingURLs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // We are decompressing URLs
            // Need a function that takes in a string input
            // This method will return an array of strings with each element being a url component


            // Steps
            // 1. Remove the "www." at the beginning on each URL
            // 2. Replace any "-" characters with a blank space
            // 3. Split the URL string every time theres a forward slash

            string exampleURL = "www.docs.microsoft.com/dotnet/csharp/whats-new/csharp-version-history";
            ParseURL(exampleURL);
            
        }

        public static void ParseURL(string url)
        {
            List<string> urlBreakdown = new List<string>();
            string currentString = "";

            for (int i = 4; i < url.Length; i++)
            {
                if (url[i] == '/')
                {
                    // Add currentString to list once we encounter a forward slash
                    urlBreakdown.Add(currentString);
                    
                    // Reinitialize currentString
                    currentString = "";  
                }
                else if (url[i] != '-')
                {
                    currentString += url[i];
                }
                if (url[i] == '-' )
                {
                    currentString += " ";
                }  
            }
            string[] parsedURL = new string[urlBreakdown.Count];
            parsedURL = urlBreakdown.ToArray();
            
            foreach(string s in parsedURL)
            {
                Console.WriteLine(s);
            }
        }
    }
}
