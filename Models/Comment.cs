namespace API_F_CS.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public int? PostId { get; set; }
        public Post? Post { get; set; }
    }
}
