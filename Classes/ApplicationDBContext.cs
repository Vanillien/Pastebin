using Microsoft.EntityFrameworkCore;
using Npgsql.EntityFrameworkCore.PostgreSQL;
using Pastebin1.Classes.Configurations;

namespace Pastebin1.Classes;

public class ApplicationDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new UserConfiguration());
    }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> wawa)
    {
        Database.EnsureCreated();
    }
}