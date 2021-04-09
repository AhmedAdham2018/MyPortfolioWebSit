using Core.Interfaces;
using Infrastructure.Repository;

namespace Infrastructure.UnitOfWork
{
    public class UnitOfWork<T> : IUnitOfWork<T> where T : class
    {
        private readonly DataContext _context;
        private GenericRepository<T> _entity;
        public UnitOfWork(DataContext context)
        {
            _context = context;

        }
        public IGenericRopository<T> Entity {
            get {
                return _entity ?? (_entity =  new GenericRepository<T>(_context));
            }
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}