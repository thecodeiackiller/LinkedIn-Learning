using System.Reflection;

namespace CarDealership
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Need to present options to users in the most efficient way possible

            // TODO Find all concrete classes that inherit from an abstract class
            // The function will take in a type for the abstract base class
            // Return a list of types containing but not including (I'm assuming the abstract class) all concrete classes that inherit from abstract class

            // Asked ChatGPT if this was even possible
            // It said no, but it could be done through some called Reflection, which I had actually encountered for the first time in the same day that I started this challenge
            // Basically, and I could be wrong, reflections allow you to gain information form metadata within an application
            // My question: When the %&$# would we need to know how to do this.. 
            // Watched this: https://www.youtube.com/watch?v=NzM8CV1TvjY
            // Phoned an expert

            // Thinking that we do something like this:
            // var newAssembly = Assembly.GetExecutingAssembly();
            // Now we can use reflection and ask newAssembly for all the types..


            // We can use reflections to basically present the data that is already there in our app, but its like the data of the data. So the information for the data that is holding other data aka metadata?
        }


    }
}
