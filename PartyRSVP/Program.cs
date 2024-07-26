namespace PartyRSVP
{
    internal class Program
    {
        static List<string> family = new List<string>() { "Harrison", "Kelsey", "Alex", "Haley" };
        static List<string> friends = new List<string>() { "James", "Hannah", "Kelly", "Alex" };
        static List<string> rsvp = new List<string>() { "Kelly", "Harrison" };
        static void Main(string[] args)
        {
            // Write a function that:

            // 1. Combines two lists
            // 2. Checks for duplicates
            // 3. Checks the combined list against a third list for overlapping items

            // No Input: The exercise won't take in any input as the exercise file from Harrison Ferrone already has 3 lists for us to work with"
            // 1 List for family, 1 List for friends, and 1 List for RSVPs

            // The output should be:
            // 1. the total number of fmaily and friends invited
            // 2. any duplicates that were sent out between family and friends list
            // 3. Names of the guests that have not RSVP'd

            // HashSets are beneficial for their performance operations when adding, subtracting, or finding overlapping datasets
            // Notable methods from HashSet class include SymetricExceptionWith, UnionWith, and IntersectWith

            Console.WriteLine("Hit ENTER to see your party invite breakdown!");
            Console.ReadKey();

            // MARK: Result
            InviteDetails();
            Console.ReadKey();
        }

        public static void InviteDetails()
        {
            List<string> set = new List<string>();
            List<string> duplicates = new List<string>();
            List<string> noRSVP = new List<string>();

            for(int i = 0; i < family.Count; i++)
            {
                if (!set.Contains(family[i]))
                {
                    set.Add(family[i]);
                }
            }
            for(int i = 0;i < friends.Count; i++) 
            {
                if (!set.Contains(friends[i]))
                {
                    set.Add(friends[i]);
                }
                else
                {
                    duplicates.Add(friends[i]);
                }
            }
            
            for (int i = 0; i < set.Count; i++)
            {
                if (!rsvp.Contains(set[i]))
                {
                    noRSVP.Add(set[i]);
                }
            }
            Console.WriteLine($"The total number of distinct friends and family were {set.Count}");
            string duplicateList = string.Join(", ", duplicates.ToArray());
            Console.WriteLine($"The duplicates were: {duplicateList}");
            string namesNoRsvp = string.Join(", ", noRSVP.ToArray());
            Console.WriteLine($"The following folks have not RSVP'd: {namesNoRsvp}"); 

        }
    }
}
