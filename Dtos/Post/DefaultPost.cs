using API_F_CS.Dtos.Comment;

namespace API_F_CS.Dtos.Post
{
    public class DefaultPost
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public List<DefaultComment> Comments {  get; set; } 
    }
}
