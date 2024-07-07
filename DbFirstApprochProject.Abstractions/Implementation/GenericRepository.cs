using DbFirstApprochProject.Abstractions.Interfaces;
using DbFirstApprochProject.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading;


namespace DbFirstApprochProject.Abstractions.Implementation
{
    public class GenericRepository<T> : IDisposable,IGenericRepository<T> where T : class
    {
        private readonly CodingNoteContext _context;
        private DbSet<T> _dbSet;
        private bool _disposed;

        public GenericRepository(CodingNoteContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
        public async Task<IEnumerable<T>> GetAll()
        {
            return await _dbSet.AsNoTracking().ToListAsync();
        }

        public async Task<bool> SaveAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            return true;
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        public async Task<T> GetById(Expression<Func<T, bool>> Predicate)
        {
            return await _dbSet.Where(Predicate).FirstOrDefaultAsync();
        }

        public Task UpdateAsync(T entity)
        {
            return Task.Run(() =>
            {
                _dbSet.Update(entity);
            });
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
        }
    }
}
