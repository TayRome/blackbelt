using Microsoft.EntityFrameworkCore;

namespace BlackBelt.Models
{
  public class BlackBeltContext : DbContext
  {
    public BlackBeltContext(DbContextOptions<BlackBeltContext> options) : base(options) {}
    public DbSet<User> Users {get; set;}
    public DbSet<Idea> Ideas {get; set;}
    public DbSet<Like> Likes {get; set;}
  }
}