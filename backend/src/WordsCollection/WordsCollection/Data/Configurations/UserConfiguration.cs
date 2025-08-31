using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WordsCollection.Models;

namespace WordsCollection.Data.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<UserModel>
{
    public void Configure(EntityTypeBuilder<UserModel> builder)
    {
        builder.ToTable("Users");
        
        builder.HasKey(x => x.Id);

        builder.OwnsOne(p => p.Email)
            .Property(p => p.EmailAddress)
            .HasColumnName("email")
            .HasMaxLength(255)
            .IsRequired();
        
        builder.OwnsOne(p => p.Password)
            .Property(p => p.PasswordValue)
            .HasColumnName("password")
            .HasMaxLength(255)
            .IsRequired();
        
        builder.HasMany(p => p.Words)
            .WithOne(p => p.User)
            .HasForeignKey(p => p.UserId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}