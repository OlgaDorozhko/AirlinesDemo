namespace AirlinesDemo.DAL
{
    using Repositories.Entities;

    public class UnitOfWork : IUnitOfWork
    {
        private readonly FlightsContext _context;

        public UnitOfWork()
        {
            _context = new FlightsContext();
        }

        public UnitOfWork(FlightsContext context)
        {
            _context = context;
        }

        public int Save()
        {
            return _context.SaveChanges();
        }

        public FlightsContext Context
        {
            get { return _context; }
        }
    }
}
