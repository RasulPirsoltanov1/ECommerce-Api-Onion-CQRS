using E_Commerce_Api.Domain.Common;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce_Api.Application.Interfaces.Repositories
{
    public interface IWriteRepository<T> where T : EntityBase
    {
        DbSet<T> Table { get; }
        Task AddAsync(T entity);
        Task AddRangeAsync(IList<T> entities);
        Task<T> UpdateAsync(T entity);
        Task HardDeleteAsync(T entity);
        Task HardDeleteRangeAsync(IList<T> entity);
        Task SoftDeleteAsync(T entity);
    }
}
