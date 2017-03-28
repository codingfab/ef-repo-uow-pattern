using System.Collections.Generic;

namespace RepositoryPatternEfCodeFirst
{
    public interface IRugbyPlayerRepository : IRepository<RugbyPlayer>
    {
        IEnumerable<RugbyPlayer> GetAllBacks();
        IEnumerable<RugbyPlayer> GetAllForwards();
    }
}