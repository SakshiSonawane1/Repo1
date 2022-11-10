using Microsoft.EntityFrameworkCore;
using Repo1.API.Models.Domain;

namespace Repo1.API.Data
{
    public class Repo1DBContext: DbContext
    {
        public Repo1DBContext(DbContextOptions<Repo1DBContext> options): base(options)
        {

        }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }
        public DbSet<WalkDifficulty> WalkDifficulty { get; set; }

    }
}
