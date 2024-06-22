using API_F_CS.Data;
using API_F_CS.Interfaces;

namespace API_F_CS.Repository
{
    public class CommentRepository : ICommentRepository
    {
        private readonly ApplicationDBContext _context;

        public CommentRepository(ApplicationDBContext context)
        {
            _context = context;
        }
    }
}
