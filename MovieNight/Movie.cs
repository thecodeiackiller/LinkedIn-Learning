using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MovieNight
{
    public class Movie
    {
        public string Title {  get; set; }
        public string Review { get; set; }
        public int Rating { get; set; }

        public Movie(string title, string review, int rating)
        {
            this.Title = title;
            this.Review = review;
            this.Rating = rating;
        }

        public override string ToString()
        {
            string stringy = $"\n Title: {this.Title} \n Review: {this.Review} \n Rating: {this.Rating}";
            string certified = "Certified Fresh";
            if(this.Rating > 75)
            {
                stringy += certified;
            }
            return stringy;
        }
    }
}
