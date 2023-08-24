using Microsoft.EntityFrameworkCore;
using MovieRank.Models;

namespace MovieRank.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<MovieRank.Models.Movie> Movie { get; set; } = default!;
    }
}