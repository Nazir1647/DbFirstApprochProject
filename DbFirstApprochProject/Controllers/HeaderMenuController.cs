using DbFirstApprochProject.Abstractions.Interfaces;
using DbFirstApprochProject.Services.IRepositories;
using Microsoft.AspNetCore.Mvc;

namespace DbFirstApprochProject.Web.Controllers
{
    public class HeaderMenuController : Controller
    {
        private readonly IHeaderMenuRepo _headerMenuRepo;

        public HeaderMenuController(IHeaderMenuRepo headerMenuRepo)
        {
            _headerMenuRepo = headerMenuRepo;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _headerMenuRepo.GetAllAsync();
            return View(data);
        }
    }
}
