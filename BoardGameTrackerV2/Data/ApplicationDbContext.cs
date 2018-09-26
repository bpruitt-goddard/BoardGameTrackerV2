using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BoardGameTrackerV2.Models;

namespace BoardGameTrackerV2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Player>().HasData(new Player { Id = -1, Name = "Unknown" });
            base.OnModelCreating(builder);
        }

        public DbSet<Game> Game { get; set; }
        public DbSet<Player> Player { get; set; }
    }
}
