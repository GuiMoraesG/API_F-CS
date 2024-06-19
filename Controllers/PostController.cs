using API_F_CS.Dtos.Post;
using API_F_CS.Interfaces;
using API_F_CS.Mappers;
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

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreatePost postUnfinished)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var post = postUnfinished.CreateToPost();

            await _postRepo.CreateAsync(post);

            return Ok(post);
        }

        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] UpdatePost postUpdated)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var post = await _postRepo.UpdateAsync(id, postUpdated);

            if (post == null)
            {
                return NotFound();
            }

            return Ok(post.Default());
        }
    }
}
