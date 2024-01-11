using E_Commerce_Api.Application.Interfaces.Repositories;
using E_Commerce_Api.Application.Interfaces.UnitOfWorks;
using E_Commerce_Api.Domain.Common;
using E_Commerce_Api.Persistance.Context;
using E_Commerce_Api.Persistance.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_Api.Persistance.UnitOfWorks
{
    internal class UnitOfWork : IUnitOfWork
    {
        AppDbContext dbContext;

        public UnitOfWork(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async ValueTask DisposeAsync() => await dbContext.DisposeAsync();

        public IReadRepository<T> GetReadRepository<T>() where T : EntityBase, new()
        {
            return new ReadRepository<T>(dbContext);
        }

        public IWriteRepository<T> GetWriteRepository<T>() where T : EntityBase, new() => new WriteRepository<T>(dbContext);

        public int Save()
        {
            return dbContext.SaveChanges();
        }

        public async Task<int> SaveAsync()
        {
            return await dbContext.SaveChangesAsync();
        }
    }
}
