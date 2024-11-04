using EF.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace EF.Domain;

public class PeopleContext: DbContext
{
    public DbSet<Person> People { get; set; }
    public DbSet<PublicFigure> PublicFigures { get; set; }
    public DbSet<Employment> Employments { get; set; }

    private string DbPath { get; }
    
    public PeopleContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "people.db");
    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Person>()
            .HasOne(p => p.Partner)
            .WithOne(p => p.PartnerTo);

        modelBuilder.Entity<Person>()
            .HasOne(p => p.Mother)
            .WithMany(p => p.MotherChildren);
        
        modelBuilder.Entity<Person>()
            .HasOne(p => p.Father)
            .WithMany(p => p.FatherChildren);

        modelBuilder.Entity<Person>()
            .HasMany<Person>(p => p.Siblings)
            .WithMany(p => p.SiblingTo);


        modelBuilder.Entity<Person>()
            .HasDiscriminator<char>("PersonType")
            .HasValue<Person>('N')
            .HasValue<PublicFigure>('E');
    }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite($"Data Source={DbPath}");
}