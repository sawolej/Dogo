using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dogo.DB.BaseRepo
{
    public interface IEntityBaseRepo<T> where T:class,IEntityBase, new()
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task AddAsync(T entity);
        Task UpdateAsync(int id, T entity);
        Task DeleteAsync(int id);

    }
}
