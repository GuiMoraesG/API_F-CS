namespace API_F_CS.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public List<Comment> Comments { get; set; } = new List<Comment>();
    }
}
