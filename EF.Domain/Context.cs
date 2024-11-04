using EF.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace EF.Domain;

public class DomainContext: DbContext
{
    public DbSet<Person> People { get; set; }
    public DbSet<PublicFigure> PublicFigures { get; set; }
    public DbSet<Employment> Employments { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Person>()
            .HasOne(p => p.Partner)
            .WithOne(p => p.PartnerTo);

        modelBuilder.Entity<Person>()
            .HasMany<Person>(p => p.Parents)
            .WithMany(p => p.Children);

        modelBuilder.Entity<Person>()
            .HasMany<Person>(p => p.Siblings)
            .WithMany(p => p.SiblingTo);


        modelBuilder.Entity<Person>()
            .Property("Discriminator")
            .HasMaxLength(200);

        modelBuilder.Entity<PublicFigure>();
    }
}