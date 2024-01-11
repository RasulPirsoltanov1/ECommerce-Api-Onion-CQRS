using E_Commerce_Api.Application.Interfaces.Repositories;
using E_Commerce_Api.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_Api.Application.Interfaces.UnitOfWorks
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        IReadRepository<T> GetReadRepository<T>() where T : EntityBase, new();
        IWriteRepository<T> GetWriteRepository<T>() where T : EntityBase, new();
        Task<int> SaveAsync();
        int Save();
    }
}
