using API_F_CS.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API_F_CS.Controllers
{
    [Route("api/Post")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostRepository _postRepo;

        public PostController(IPostRepository postRepo)
        {
            _postRepo = postRepo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var posts = await _postRepo.GetAllAsync();

            return Ok(posts);
        }

        [HttpGet("{Id:int}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var post = await _postRepo.GetByIdAsync(id);

            return Ok(post);
        }

    }
}
