using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.MovieApp.Domain
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
