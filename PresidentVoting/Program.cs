namespace PresidentVoting
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Person OldEnough = new Person("John", 51);
            OldEnough.TimesVoted(OldEnough.age);

            Person TooYoung = new Person("Bryian", 17);
            TooYoung.TimesVoted(OldEnough.age);
        }
    }
}
