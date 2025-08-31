using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WordsCollection.Models;

namespace WordsCollection.Data.Configurations;

public class WordConfiguration : IEntityTypeConfiguration<WordModel>
{
    public void Configure(EntityTypeBuilder<WordModel> builder)
    {
        builder.ToTable("Words");
        
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Sentence)
            .HasMaxLength(255)
            .IsRequired();
        
        builder.Property(p => p.Meaning)
            .HasMaxLength(255)
            .IsRequired();
        
        builder.Property(p => p.CreatedAt)
            .IsRequired();

        builder.HasOne(p => p.User)
            .WithMany(p => p.Words)
            .HasPrincipalKey(p => p.Id);
    }
}