using Layered.DAL.Context;
using Layered.Domain.Repository;

namespace Layered.DAL.Implementation
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public readonly MovieDbContext _context;
        public GenericRepository(MovieDbContext context) => _context = context;

        public void Add(T entity)
        {
              _context.Set<T>().Add(entity);
        }

        public IEnumerable<T> Find(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().Where(predicate);
        }

        public IEnumerable<T> GetAll()
        {
           return _context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Remove(T entity)
        {
             _context.Set<T>().Remove(entity);
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }
    }
}