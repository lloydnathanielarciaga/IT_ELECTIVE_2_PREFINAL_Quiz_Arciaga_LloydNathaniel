using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyPortfolioMVC.Data;
using MyPortfolioMVC.Models;

namespace MyPortfolioMVC.Controllers
{
    [Authorize]
    public class ProjectController : Controller
    {
        public IActionResult Details(int id)
        {
            var project = ProjectData.Projects.FirstOrDefault(p => p.Id == id);
            if (project == null) return NotFound();

            ViewBag.Comments = ProjectData.Comments
                                .Where(c => c.ProjectId == id)
                                .OrderByDescending(c => c.Timestamp)
                                .ToList();

            return View(project);
        }

        [HttpPost]
        public IActionResult AddComment(int projectId, string authorName, string content)
        {
            if (!string.IsNullOrWhiteSpace(authorName) && !string.IsNullOrWhiteSpace(content))
            {
                var comment = new Comment
                {
                    Id = ProjectData.Comments.Count + 1,
                    ProjectId = projectId,
                    AuthorName = authorName,
                    Content = content
                };
                ProjectData.Comments.Add(comment);
            }
            return RedirectToAction("Details", new { id = projectId });
        }
    }
}