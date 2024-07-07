using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DbFirstApprochProject.Abstractions.Interfaces
{
    public interface IGenericRepository<T> :IDisposable
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(Expression<Func<T, bool>> Predicate);
        Task<bool> Add(T entity);
        void Delete(T entity);
        Task Update(T entity);
    }
}
