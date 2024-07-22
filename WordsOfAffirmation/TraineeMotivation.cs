using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordsOfAffirmation
{
    public class TraineeMotivation
    {
        public string Name { get; set; }

        public TraineeMotivation(string name) 
        {
            this.Name = name;
        }

        public List<string> motivationMessages = new List<string>
        {
            "Keep up the good work",
            "You've come to far to stop now",
            "Push it, push it real good",
            "Get your ass in gear",
            "Time to take it to the next level",
            "Seperate yourself right here",
            "Stay in the moment"
        };

        
        
    }
}
