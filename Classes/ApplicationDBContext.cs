using Microsoft.EntityFrameworkCore;
using Npgsql.EntityFrameworkCore.PostgreSQL;
using Pastebin1.Classes.Configurations;

namespace Pastebin1.Classes;

public class ApplicationDBContext : DbContext
{
    public DbSet<User> Users { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //optionsBuilder.LogTo(Console.WriteLine);
        
        //optionsBuilder.UseNpgsql("Host=localhost;Username=postgres;Password=rr7kyy00;Port=5432");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new UserConfiguration());
    }

    public ApplicationDBContext()
    {
        Database.EnsureCreated();
    }
}