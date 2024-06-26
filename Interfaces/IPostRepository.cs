using API_F_CS.Dtos.Post;
using API_F_CS.Models;

namespace API_F_CS.Interfaces
{
    public interface IPostRepository
    {
        Task<List<Post>> GetAllAsync();
        Task<Post?> GetByIdAsync(int id);
        Task<Post> CreateAsync(Post post);
        Task<Post?> UpdateAsync(int id, UpdatePost post);
        Task<Post?> DeleteAsync(int id);
        Task<bool> AynPostAsync(int id);
    }
}
