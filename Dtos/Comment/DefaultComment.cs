namespace API_F_CS.Dtos.Comment
{
    public class DefaultComment
    {
        public int Id { get; set; }
        public string Text { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public int? PostId { get; set; }
    }
}
