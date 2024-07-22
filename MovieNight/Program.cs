namespace MovieNight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ToString Method which is apart of the System class just prints a class name. 

            // Challenge:
            // Write a custom message so when the user calls the ToString() method, they get a custom message

            // The function will not take in any input parameters
            // The function will return a string

            // The base class already has Movie class set up with Title, Rating, and Review score fields 
            // The base code already has Movies setup and the ToString method called on those instances of the classes. We'll make our own movies. 

            // The custom description needs to print out the Title, Rating, and Review score for the movie
            // If the review is higher than 75, the description also needs to mention that the movie is "certified fresh."

            Movie Movie1 = new Movie("Shawshank Redemption", "Very good plot", 74);
            Movie Movie2 = new Movie("Ferris Buehlers Day Off", "Sloane is hot and Cameron is depressed", 86);
            Console.WriteLine(Movie1.ToString());
            Console.WriteLine(Movie2.ToString());

        }
    }
}
