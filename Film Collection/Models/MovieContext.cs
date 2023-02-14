using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Film_Collection.Models
{
    public class MovieContext : DbContext
    {
        //Constructor
        public MovieContext (DbContextOptions<MovieContext> options): base(options)
        {
            //leave blank
        }

        public DbSet<MovieRatings> responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<MovieRatings>().HasData(
                new MovieRatings
                {
                    MovieId = 1,
                    Category = "Adventure/Musical",
                    Year = 1997,
                    MovieTitle = "Hercules",
                    Director = "Rone Clements, John Musker",
                    Rating = "G",
                    Edited = true,
                    LentTo = "",
                    Notes = "Best nostalgic movie ever!"
                },
                new MovieRatings
                {
                    MovieId = 2,
                    Category = "Action/Adventure",
                    Year = 2022,
                    MovieTitle = "Black Panther:Wakanda Forever",
                    Director = "Ryan Coogler",
                    Rating = "PG-13",
                    Edited = true,
                    LentTo = "Taylor B.",
                    Notes = ""
                },
                new MovieRatings
                {
                    MovieId = 3,
                    Category = "Musical/Romance",
                    Year = 20,
                    MovieTitle = "Mamma Mia!",
                    Director = "Phyllida Lloyd",
                    Rating = "PG-13",
                    Edited = true,
                    LentTo = "",
                    Notes = "Best for a girls night sing along."
                }
            );
        }
    }
}
