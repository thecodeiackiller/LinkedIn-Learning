using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresidentVoting
{
    public class Person
    {
        public string name { get; set; }
        public int age { get; set; }

        public Person(string Name, int Age)
        {
            this.name = Name;
            this.age = Age;
        }


        public int TimesVoted(int age)
        {
            int personVoteCount = 0;
            if (age > 18)
            {
                personVoteCount = (age - 18) / 4;
                return personVoteCount;

            }
            else
            {
                personVoteCount = 0;
                return personVoteCount;
            }
            

        }
    }
}
