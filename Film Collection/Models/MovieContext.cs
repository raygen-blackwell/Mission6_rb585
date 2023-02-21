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
        public DbSet<Category> Categories { get; set; }

        // Seed data
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { CategoryID = 1, CategoryName = "Action/Adventure" },
                new Category { CategoryID = 2, CategoryName = "Comedy" },
                new Category { CategoryID = 3, CategoryName = "Drama" },
                new Category { CategoryID = 4, CategoryName = "Family" },
                new Category { CategoryID = 5, CategoryName = "Horror/Suspense" },
                new Category { CategoryID = 6, CategoryName = "Miscellaneous" },
                new Category { CategoryID = 7, CategoryName = "Television" },
                new Category { CategoryID = 8, CategoryName = "VHS" }
            ) ; 
            mb.Entity<MovieRatings>().HasData(
                new MovieRatings
                {
                    MovieId = 1,
                    CategoryID = 4,
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
                    CategoryID = 1,
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
                    CategoryID = 6,
                    Year = 2016,
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
