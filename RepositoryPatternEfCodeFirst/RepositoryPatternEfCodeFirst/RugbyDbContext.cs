using System.Data.Entity;

namespace RepositoryPatternEfCodeFirst
{
    public class RugbyDbContext : DbContext
    {
        public RugbyDbContext() : base("name=RugbyDbConnectionString")
        {
            
        }

        public DbSet<RugbyPlayer> RugbyPlayers { get; set; }
    }
}