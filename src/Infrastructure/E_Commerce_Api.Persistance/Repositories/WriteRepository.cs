using E_Commerce_Api.Application.Interfaces.Repositories;
using E_Commerce_Api.Domain.Common;
using E_Commerce_Api.Persistance.Context;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce_Api.Persistance.Repositories
{
    public class WriteRepository<T> : IWriteRepository<T> where T : EntityBase
    {
        AppDbContext dbContext;

        public WriteRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public DbSet<T> Table => dbContext.Set<T>();

        public async Task AddAsync(T entity)
        {
            await Table.AddAsync(entity);
        }

        public async Task AddRangeAsync(IList<T> entities)
        {
            await Table.AddRangeAsync(entities);
        }

        public async Task HardDeleteAsync(T entity)
        {
            await Task.Run(() =>
            {
                Table.Remove(entity);
            });
           
        }

        public async Task SoftDeleteAsync(T entity)
        {
            await Task.Run(() =>
            {
                entity.IsDeleted = true;
                Table.Update(entity);
            });
        }

        public async Task<T> UpdateAsync(T entity)
        {
            await Task.Run(() =>
            {
                Table.Update(entity);
            });
            return entity;
        }
    }
}
