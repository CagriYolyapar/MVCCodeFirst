using MVCCodeFirst_0.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCCodeFirst_0.Models.Context
{
    public class MyContext:DbContext
    {
        public MyContext():base("MyConnection")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MovieArtist>().Ignore(x => x.ID);
            modelBuilder.Entity<MovieArtist>().HasKey(x => new
            {
                x.ArtistID,
                x.MovieID
            });
            modelBuilder.Entity<Director>().Ignore(x => x.FullName);
        }

        public DbSet<Artist> Artists { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MovieArtist> MovieArtists { get; set; }

    }
}