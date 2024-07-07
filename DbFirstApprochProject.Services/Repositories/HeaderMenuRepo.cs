using AutoMapper;
using DbFirstApprochProject.Abstractions.Interfaces;
using DbFirstApprochProject.Data.Models;
using DbFirstApprochProject.Services.IRepositories;
using DbFirstApprochProject.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DbFirstApprochProject.Services.Repositories
{
    public class HeaderMenuRepo : IHeaderMenuRepo
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public HeaderMenuRepo(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;

        }

        public Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<HeaderMenuVM>> GetAllAsync()
        {
            var data = await _unitOfWork.GenericRepository<HeaderMenu>().GetAll();
            return _mapper.Map<List<HeaderMenuVM>>(data).ToList();
        }

        public Task<HeaderMenuVM> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveAsync(HeaderMenuVM headerMenu)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(HeaderMenuVM headerMenu)
        {
            throw new NotImplementedException();
        }
    }
}
