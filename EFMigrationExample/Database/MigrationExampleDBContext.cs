using EFMigrationExample.Entities;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace EFMigrationExample.Database
{
    public class MigrationExampleDBContext : DbContext, IMigrationExampleDBContext
    {
        public MigrationExampleDBContext(DbContextOptions<MigrationExampleDBContext> options) : base(options)
        {
        }

        public DbContext DbContext
        {
            get
            {
                return this;
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Genre>().HasKey(prop => prop.Id);
            //modelBuilder.Entity<Genre>().Property(prop => prop.Name).HasMaxLength(150).IsRequired();
            //modelBuilder.Entity<Genre>().ToTable(name: "tb_Genero", schema: "Peliculas");

            //modelBuilder.Entity<Actor>().Property(prop => prop.BirthDate).HasColumnType("Date");
            //modelBuilder.Entity<Cinema>().Property(prop => prop.Price).HasPrecision(9, 2);
            //modelBuilder.Entity<MovieActor>().HasKey(prop => new { prop.MovieId, prop.ActorId });   
         }

        public virtual DbSet<Genre> Genres
        {
            get; set;
        }

       /*public virtual DbSet<Actor> Actors { get; set; }

        public virtual DbSet<Cinema> Cinemas { get; set; }*/
    }
}
