using Microsoft.AspNetCore.Mvc;
using MyPortfolioMVC.Data;

namespace MyPortfolioMVC.Controllers
{
    public class PortfolioController : Controller
    {
        public IActionResult Index()
        {
            return View(ProjectData.Projects);
        }
    }
}
