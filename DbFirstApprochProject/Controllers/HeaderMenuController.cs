using DbFirstApprochProject.Abstractions.Interfaces;
using DbFirstApprochProject.Services.IRepositories;
using DbFirstApprochProject.Services.Models;
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

        public async Task<IActionResult> SaveHeader()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SaveHeader(HeaderMenuVM form)
        {
            await _headerMenuRepo.SaveAsync(form);
            return RedirectToAction("Index");
        }
    }
}
