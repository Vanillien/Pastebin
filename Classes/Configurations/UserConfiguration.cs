using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Pastebin1.Classes.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
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
    }
}

