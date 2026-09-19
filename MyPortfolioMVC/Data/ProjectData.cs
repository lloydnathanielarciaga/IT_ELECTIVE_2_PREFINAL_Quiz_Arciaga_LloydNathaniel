using MyPortfolioMVC.Models;

namespace MyPortfolioMVC.Data
{
    public class ProjectData
    {
        public static List<Project> Projects { get; set; } = new List<Project>();
        public static List<Comment> Comments { get; set; } = new List<Comment>();

        static ProjectData()
        {
            for (int i = 1; i <= 14; i++)
            {
                Projects.Add(new Project
                {
                    Id = i,
                    Title = $"",
                    Description = $"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                    GitHubLink = $"",
                    ImageUrl = $""
                });
            }
        }
    }
}
