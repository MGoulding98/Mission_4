using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission_4.Models
{
    public class MovieApplicationContext : DbContext
    {
        // Constructor
        public MovieApplicationContext (DbContextOptions<MovieApplicationContext> options) : base (options)
        {

        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Category> Categories { get; set; }

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

            );

            mb.Entity<Movie>().HasData(

               new Movie
               {
                   MovieID = 1,
                   CategoryID = 2,
                   Title = "Trainspotting",
                   Year = 1996,
                   Director = "Danny Boyle",
                   Rating = "R",
                   Edited = false,
                   LentTo = "Matt Goulding",
                   Notes = "Best movie ever!"
               },

               new Movie
               {
                   MovieID = 2,
                   CategoryID = 5,
                   Title = "Cure",
                   Year = 1997,
                   Director = "Kiyoshi Kurosawa",
                   Rating = "R",
                   Edited = false,
                   LentTo = "Matt Goulding",
                   Notes = "This one melts your brain."
               },

               new Movie
               {
                   MovieID = 3,
                   CategoryID = 2,
                   Title = "A Summer's Tale",
                   Year = 1996,
                   Director = "Éric Rohmer",
                   Rating = "G",
                   Edited = false,
                   LentTo = "Matt Goulding",
                   Notes = "My favorite RomCom."
               }
            );
        }
    }
}
