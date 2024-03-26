using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Domain.Models
{
    public class Cinema
    {
        public string Name { get; set; }
        public List<int> Halls { get; set; }
        public List<Movie> Movies { get; set; }
        public Cinema(string name)
        {
            if(string.IsNullOrEmpty(name)) throw new ArgumentNullException("Name is Required");
            Halls = new List<int>();
            Movies = new List<Movie>();
        }
        public Cinema() 
        {
            Halls = new List<int>();
            Movies = new List<Movie>();
        }
        public void MoviePlaying(Movie movie)
        {
            if(movie == null)
            {
                throw new Exception("Must have value of a Movie Playing");
                //return
            }

            //Check if the movie is part of the movie list
            Movie foundMovie = Movies.FirstOrDefault(m => m.Title.ToLower() == movie.Title.ToLower());
            if (foundMovie == null)
            {
                throw new Exception($"Movie is not part of the list");
            }
            Console.WriteLine($"We are watching movie {movie.Title}");
        }
    }
}
