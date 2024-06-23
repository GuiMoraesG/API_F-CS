using API_F_CS.Models;

namespace API_F_CS.Interfaces
{
    public interface ICommentRepository
    {
        Task<List<Comment>> GetAllAsync();
    }
}
