using API_F_CS.Data;
using API_F_CS.Interfaces;
using API_F_CS.Models;
using Microsoft.EntityFrameworkCore;

namespace API_F_CS.Repository
{
    public class CommentRepository : ICommentRepository
    {
        private readonly ApplicationDBContext _context;

        public CommentRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<List<Comment>> GetAllAsync()
        {
            var comments = await _context.Comments.ToListAsync();

            return comments;
        }
    }
}
