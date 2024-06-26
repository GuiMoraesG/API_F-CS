using API_F_CS.Dtos.Comment;
using API_F_CS.Models;

namespace API_F_CS.Mappers
{
    public static class CommentMappers
    {
        public static DefaultComment Default(this Comment comment)
        {
            return new DefaultComment
            {
                Id = comment.Id,
                Text = comment.Text,
                CreatedDate = comment.CreatedDate,
                PostId = comment.PostId,
            };
        }

        public static Comment CreateToComment(this CreatedComment cComment, int postId)
        {
            return new Comment
            {
                Text = cComment.Text,
                PostId = postId,
            };
        }
    }
}
