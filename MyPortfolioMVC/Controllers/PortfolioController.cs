using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyPortfolioMVC.Data;

namespace MyPortfolioMVC.Controllers
{
    [Authorize]
    public class PortfolioController : Controller
    {
        public IActionResult Index()
        {
            return View(ProjectData.Projects);
        }
    }
}