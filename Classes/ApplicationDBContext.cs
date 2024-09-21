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

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>(builder =>
        {
            builder.ToTable("Users"); //Здаемъ наименование для таблицы

            builder.Property(p => p.Id) //задаемъ свойства колоночкамъ
                .HasColumnName("Id")
                .ValueGeneratedOnAdd();

            builder.Property(p => p.Username)
                .HasColumnName("Username")
                .HasMaxLength(30)
                .IsRequired();
            
            builder.Property(p => p.Email)
                .HasColumnName("Email")
                .HasMaxLength(100)
                .IsRequired();
            
            builder.Property(p => p.Password)
                .HasColumnName("Password")
                .HasMaxLength(30)
                .IsRequired();            
        });
    }

    public ApplicationDBContext()
    {
        Database.EnsureCreated();
    }
}