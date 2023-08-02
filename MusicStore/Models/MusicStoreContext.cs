using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace MusicStore.Models
{
    public partial class MusicStoreContext : DbContext
    {
        public MusicStoreContext()
            : base("name=MusicStoreContext")
        {
        }

        public virtual DbSet<Administrator> Administrators { get; set; }
        public virtual DbSet<Album> Albums { get; set; }
        public virtual DbSet<Artist> Artists { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<FeaturedArtist> FeaturedArtists { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Review> Reviews { get; set; }
        public virtual DbSet<Song> Songs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Administrator>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<Administrator>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<Album>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Album>()
                .Property(e => e.albumCover)
                .IsUnicode(false);

            modelBuilder.Entity<Album>()
                .HasMany(e => e.Songs)
                .WithRequired(e => e.Album)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Artist>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Artist>()
                .HasMany(e => e.FeaturedArtists)
                .WithRequired(e => e.Artist)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.firstname)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.lastname)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Reviews)
                .WithRequired(e => e.Customer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Genre>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Genre>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<Genre>()
                .HasMany(e => e.Songs)
                .WithRequired(e => e.Genre)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Review>()
                .Property(e => e.ratingValue)
                .HasPrecision(3, 1);

            modelBuilder.Entity<Review>()
                .Property(e => e.comment)
                .IsUnicode(false);

            modelBuilder.Entity<Song>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Song>()
                .Property(e => e.duration)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Song>()
                .HasMany(e => e.FeaturedArtists)
                .WithRequired(e => e.Song)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Song>()
                .HasMany(e => e.Reviews)
                .WithRequired(e => e.Song)
                .WillCascadeOnDelete(false);
        }
    }
}
