namespace RepositoryPatternEfCodeFirst
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly RugbyDbContext _context;

        public UnitOfWork(RugbyDbContext context)
        {
            _context = context;
            RugbyPlayers = new RugbyPlayerRepository(_context);

        }

        public IRugbyPlayerRepository RugbyPlayers { get; private set; }

        public void Dispose()
        {
            _context.Dispose();
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }
    }
}