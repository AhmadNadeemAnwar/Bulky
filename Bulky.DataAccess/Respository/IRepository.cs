using System.Linq.Expressions;

namespace Bulky.DataAccess.Respository
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll(string? includeProperties = null);

        T? Get(Expression<Func<T,bool>> filter, string? includeProperties = null);
        void Add(T Entity);

        void Update(T entity);

        void Remove(T entity);

        void RemoveAll(IEnumerable<T> entity);
    }
}
