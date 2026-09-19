namespace MyPortfolioMVC.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public string AuthorName { get; set; }
        public string Content { get; set; }
        public DateTime Timestamp { get; set; } = DateTime.Now;
    }
}
