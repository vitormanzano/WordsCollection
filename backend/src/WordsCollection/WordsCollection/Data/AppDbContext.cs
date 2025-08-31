using Microsoft.EntityFrameworkCore;
using WordsCollection.Data.Configurations;
using WordsCollection.Models;

namespace WordsCollection.Data;

public class AppDbContext : DbContext
{
    public DbSet<UserModel> Users { get; set; }
    public DbSet<WordModel> Words { get; set; }
    
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new UserConfiguration());
        modelBuilder.ApplyConfiguration(new WordConfiguration());
    }
}