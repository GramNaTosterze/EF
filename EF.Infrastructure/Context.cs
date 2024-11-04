using Microsoft.EntityFrameworkCore;

using EF.Domain;

namespace EF.Infrastructure;

public class EFContext: DomainContext
{

    private string DbPath { get; }
    
    public EFContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "people.db");
    }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite($"Data Source={DbPath}");
}