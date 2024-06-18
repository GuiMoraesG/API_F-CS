using API_F_CS.Dtos.Post;
using API_F_CS.Models;

namespace API_F_CS.Mappers
{
    public static class PostMappers
    {
        public static Post CreateToPost(this CreatePost post)
        {
            return new Post
            {
                Title = post.Title,
                Description = post.Description,
            };
        }
    }
}
