using MovieApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Domain.Models
{
    public class Movie
    {
        public string Title { get; set; }
        public Genre Genre { get; set; }
        public int Rating { get; set; }
        public int TicketPrice { get; set; }

        public Movie() { }
        public Movie(string title, Genre genre,int rating)
        {
            if(string.IsNullOrEmpty(title)) 
            {
                throw new ArgumentNullException("Title must have value");
            }
            this.Title = title;
            this.Genre = genre;
            if(rating < 1 || rating > 5) 
            {
                throw new InvalidDataException("Rating should have a value between 1 and 5");
            }
            this.Rating = rating;
            this.TicketPrice = rating * 5;
        }
    }
}
