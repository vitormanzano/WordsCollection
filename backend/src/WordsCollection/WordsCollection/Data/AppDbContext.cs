using Microsoft.EntityFrameworkCore;
using WordsCollection.Models;

namespace WordsCollection.Data;

public class AppDbContext : DbContext
{
    public DbSet<UserModel> Users { get; set; }
    public DbSet<WordModel> Words { get; set; }
    
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
}