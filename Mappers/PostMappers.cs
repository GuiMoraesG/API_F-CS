using API_F_CS.Dtos.Post;
using API_F_CS.Models;

namespace API_F_CS.Mappers
{
    public static class PostMappers
    {
        public static DefaultPost Default(this Post post)
        {
            return new DefaultPost
            {
                Title = post.Title,
                Description = post.Description
            };
        }

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
