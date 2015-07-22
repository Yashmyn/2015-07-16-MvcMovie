using System;
using System.ComponentModel.DataAnnotations; //added this using statement
using System.Data.Entity;

namespace _2015_07_16_MvcMovie.Models  //created my first model
{
    public class Movie //created class Movie
    {
        public int ID { get; set; }
        [StringLength(60, MinimumLength = 3)]
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        //added above three attributes

        public DateTime ReleaseDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [Required]
        [StringLength(30)]
        
        public string Genre { get; set; }
        [Range(1, 100)]
        [DataType(DataType.Currency)]

        public decimal Price { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [StringLength(5)]
        public string Rating { get; set; }
    }
    
    public class MovieDBContext : DbContext  //created this database-container for items of type Movie
    {
        public DbSet<Movie> Movies { get; set; }
    }
}