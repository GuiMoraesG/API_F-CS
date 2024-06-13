namespace API_F_CS.Models
{
    public class Post
    {
        int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        List<Comment> comments { get; set; } = new List<Comment>();
    }
}
