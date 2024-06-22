using API_F_CS.Data;
using API_F_CS.Dtos.Post;
using API_F_CS.Interfaces;
using API_F_CS.Models;
using Microsoft.EntityFrameworkCore;

namespace API_F_CS.Repository
{
    public class PostRepository : IPostRepository
    {
        private readonly ApplicationDBContext _context;

        public PostRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<List<Post>> GetAllAsync()
        {
            return await _context.Posts.ToListAsync();
        }

        public async Task<Post?> GetByIdAsync(int id)
        {
            var post = await _context.Posts.FirstOrDefaultAsync(p => p.Id == id);

            if (post == null)
            {
                return null;
            }

            return post;
        }

        public async Task<Post> CreateAsync(Post post)
        {
            await _context.Posts.AddAsync(post);
            await _context.SaveChangesAsync();

            return post;
        }

        public async Task<Post?> UpdateAsync(int id, UpdatePost postUpdated)
        {
            var post = await _context.Posts.FirstOrDefaultAsync(p => p.Id == id);

            if (post == null)
            {
                return null;
            }

            post.Title = postUpdated.Title;
            post.Description = postUpdated.Description;

            await _context.SaveChangesAsync();

            return post;
        }

        public async Task<Post?> DeleteAsync(int id)
        {
            var post = await _context.Posts.FirstOrDefaultAsync(p => p.Id == id);

            if (post == null)
            {
                return null;
            }

            _context.Posts.Remove(post);
            await _context.SaveChangesAsync();

            return post;
        }
    }
}
