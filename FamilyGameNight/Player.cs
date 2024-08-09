using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FamilyGameNight
{
    
    public class Player
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PreviousScore { get; set; }
        public int RecentScore { get; set; }

        public Player(string firstname, string lastname, int previousscore, int recentscore)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.PreviousScore = previousscore;
            this.RecentScore = recentscore;
        }

        public static void filterPlayers(List<Player> players, int scoreDifferential)
        {
            var filteredAndGroupedPlayers = players
                .Where(p => (p.RecentScore - p.PreviousScore) > scoreDifferential)
                .GroupBy(p => p.LastName.First())
                .OrderBy(p => p.Key);

            foreach (Group filteredPlayers in filteredAndGroupedPlayers)
            {
                Console.WriteLine($"Those with first initial {filteredPlayers.Value} of last name starting with");
            }
        }


    }
}
