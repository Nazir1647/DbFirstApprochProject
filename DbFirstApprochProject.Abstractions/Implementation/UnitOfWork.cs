using DbFirstApprochProject.Abstractions.Interfaces;
using DbFirstApprochProject.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFirstApprochProject.Abstractions.Implementation
{
    public class UnitOfWork : IUnitOfWork , IDisposable
    {
        private readonly CodingNoteContext _context;
        private bool _disposed;

        public UnitOfWork(CodingNoteContext context)
        {
            _context = context;
        }

        public IGenericRepository<T> GenericRepository<T>() where T : class
        {
            IGenericRepository<T> repo = new GenericRepository<T>(_context);
            return repo;
        }

        public async Task SaveAsync()
        {
           await _context.SaveChangesAsync();
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
