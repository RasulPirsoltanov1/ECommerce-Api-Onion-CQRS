using E_Commerce_Api.Application.Interfaces.Repositories;
using E_Commerce_Api.Domain.Common;
using E_Commerce_Api.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_Api.Persistance.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : class, IEntityBase, new()
    {
        public AppDbContext _dbContext { get; set; }

        public ReadRepository(AppDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public DbSet<T> Table => _dbContext.Set<T>();



        public async Task<IList<T>> GetAllAsync(
    Expression<Func<T, bool>>? expression = null,
    Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null,
    Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
    bool enableTracking = false)
        {
            IQueryable<T> queryable = Table;

            if (!enableTracking)
                queryable = queryable.AsNoTracking();

            if (include is not null)
                queryable = include(queryable);

            if (expression is not null)
                queryable = queryable.Where(expression);

            if (orderBy is not null)
                return await orderBy(queryable).ToListAsync();

            return await queryable.ToListAsync();
        }


        public async Task<IList<T>> GetAllAsyncByPaging(Expression<Func<T, bool>>? expression = null, Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null, Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null, bool enableTracking = false, int currentPage = 1, int pageSize = 3)
        {
            IQueryable<T> queryable = Table;
            if (!enableTracking) queryable = queryable.AsNoTracking();
            if (include is not null) include(queryable);
            if (expression is not null) queryable.Where(expression);
            if (orderBy is not null) return await orderBy(queryable).Skip(pageSize * (currentPage - 1)).Take(pageSize).ToListAsync();
            return await queryable.Skip(pageSize * (currentPage - 1)).Take(pageSize).ToListAsync();
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> expression, Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null, bool enableTracking = false)
        {
            IQueryable<T> queryable = Table;
            if (!enableTracking) queryable = queryable.AsNoTracking();
            if (include is not null) include(queryable);
            return await queryable.FirstOrDefaultAsync(expression);
        }

        public IQueryable<T> Find(Expression<Func<T, bool>> predicate, bool enableTracking = false)
        {
            if (enableTracking)
                return Table.Where(predicate);
            return Table.AsNoTracking().Where(predicate);
        }

        public async Task<int> CountAsync(Expression<Func<T, bool>>? predicate = null)
        {
            return await Table.AsNoTracking().CountAsync(predicate);
        }
    }
}
