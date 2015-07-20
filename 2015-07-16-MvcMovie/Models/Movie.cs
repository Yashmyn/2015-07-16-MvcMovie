using System;
using System.Data.Entity;

namespace _2015_07_16_MvcMovie.Models  //created my first model
{
    public class Movie //created class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }
    
    public class MovieDBContext : DbContext  //created this database-container for items of type Movie
    {
        public DbSet<Movie> Movies { get; set; }
    }
}