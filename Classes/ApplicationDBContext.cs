using Microsoft.EntityFrameworkCore;
using Npgsql.EntityFrameworkCore.PostgreSQL;

namespace Pastebin1.Classes;

public class ApplicationDBContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //optionsBuilder.LogTo(Console.WriteLine);
        
        //optionsBuilder.UseNpgsql("Host=localhost;Username=postgres;Password=rr7kyy00;Port=5432");
    }

    public ApplicationDBContext()
    {
        Database.EnsureCreated();
    }
}