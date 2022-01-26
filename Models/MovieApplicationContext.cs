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

        public DbSet<MovieModel> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<MovieModel>().HasData(

               new MovieModel
               {
                   MovieID = 1,
                   Category = "Dark Comedy",
                   Title = "Trainspotting",
                   Year = 1996,
                   Director = "Danny Boyle",
                   Rating = "R",
                   Edited = false,
                   LentTo = "Matt Goulding",
                   Notes = "Best movie ever!"
               },

               new MovieModel
               {
                   MovieID = 2,
                   Category = "Thriller",
                   Title = "Cure",
                   Year = 1997,
                   Director = "Kiyoshi Kurosawa",
                   Rating = "R",
                   Edited = false,
                   LentTo = "Matt Goulding",
                   Notes = "This one melts your brain."
               },

               new MovieModel
               {
                   MovieID = 3,
                   Category = "Romantic Comedy",
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
