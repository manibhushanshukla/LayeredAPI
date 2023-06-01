using System.Linq.Expressions;

namespace Layered.Domain.Repository
{
    public interface IGenericRepository<T> where T:class
    {
        void Add(T entity);
        void Update(T entity);
        T GetById(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Expression<Func<T,bool>> predicate);

        void Remove(T entity);
    }
}