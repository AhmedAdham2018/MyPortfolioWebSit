using Microsoft.EntityFrameworkCore;
using Core.Entities;
using System;

namespace Infrastructure
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Developer>()
                .Property(x => x.Id)
                .HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<ProjectItem>()
                .Property(x => x.Id)
                .HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<Developer>().HasData(
                new Developer()
                {
                    Id = Guid.NewGuid(),
                    Avatar = "avatar.jpg",
                    Fullname = "Ahmed Adham Afandy",
                    Profile = "Software Engineer - .NET 5 Web Developer",
                }
            );
        }

        public DbSet<Developer> Developers { get; set; }
        public DbSet<ProjectItem> ProjectItem { get; set; }
    }
}