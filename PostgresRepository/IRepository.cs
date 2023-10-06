using System.Linq.Expressions;

namespace PostgresRepository;

internal interface IRepository<T> where T : class
{
    Task<IEnumerable<T>> GetAllAsync();
    Task<T> GetByIdAsync(int id);
    Task AddAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(T entity);
    Task<List<T>> GetEntitiesAsync<T>(Expression<Func<T, bool>> predicate,
        params Expression<Func<T, object>>[] includes) where T : class;

}