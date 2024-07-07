using DbFirstApprochProject.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFirstApprochProject.Services.IRepositories
{
    public interface IHeaderMenuRepo 
    {
        Task<IEnumerable<HeaderMenuVM>> GetAllAsync();
        Task<HeaderMenuVM> GetByIdAsync(int id);
        Task<bool> SaveAsync(HeaderMenuVM headerMenu);
        Task<bool> DeleteAsync(int id);
        Task<bool> UpdateAsync(HeaderMenuVM headerMenu);

    }
}
