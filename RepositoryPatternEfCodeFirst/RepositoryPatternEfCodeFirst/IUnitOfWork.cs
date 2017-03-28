using System;
using System.Collections.Generic;
using System.Linq;

namespace RepositoryPatternEfCodeFirst
{
    public interface IUnitOfWork : IDisposable
    {
        IRugbyPlayerRepository RugbyPlayers { get; }
        int Complete();
    }

    public class RugbyPlayerRepository : Repository<RugbyPlayer>, IRugbyPlayerRepository
    {
        public RugbyPlayerRepository(RugbyDbContext context) : base(context)
        {

        }

        public IEnumerable<RugbyPlayer> GetAllBacks()
        {
            return RugbyContext.RugbyPlayers.Where(r => r.Number >= 9 && r.Number <= 15).ToList();
        }

        public IEnumerable<RugbyPlayer> GetAllForwards()
        {
            return RugbyContext.RugbyPlayers.Where(r => r.Number >=1 && r.Number <= 8).ToList();
        }

        public RugbyDbContext RugbyContext { get { return Context as RugbyDbContext; } }
    }
}