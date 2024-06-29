using API_F_CS.Dtos.Comment;
using API_F_CS.Interfaces;
using API_F_CS.Mappers;
using API_F_CS.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_F_CS.Controllers
{
    [Route("api/Comment")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly ICommentRepository _commentRepo;
        private readonly IPostRepository _postRepo;

        public CommentController(ICommentRepository commentRepo, IPostRepository postRepo)
        {
            _commentRepo = commentRepo;
            _postRepo = postRepo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var comments = await _commentRepo.GetAllAsync();
            var DefaulC = comments.Select(c => c.Default());

            return Ok(DefaulC);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var comment = await _commentRepo.GetByIdAsync(id);

            if (comment == null)
            {
                return NotFound();
            }

            return Ok(comment.Default());
        }

        [HttpPost("{postId:int}")]
        public async Task<IActionResult> CreateComment([FromRoute] int postId, [FromBody] CreatedComment cComment)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var exist = await _postRepo.AynPostAsync(postId);

            if (!exist)
            {
                return NotFound();
            }

            var commentModel = cComment.CreateToComment(postId);
            var comment = await _commentRepo.CreateAsync(commentModel);

            return Ok(comment.Default());
        }

        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> UpdateComment([FromRoute] int id, [FromBody] UpdatedComment comment)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var commentModel = comment.UpdateToComment();
            var commentF = await _commentRepo.UpdateAsync(commentModel, id);

            if (commentF == null)
            {
                return NotFound();
            }

            return Ok(commentF.Default());
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> DeleteComment([FromRoute] int id)
        {
            var comment = await _commentRepo.DeleteAsync(id);

            if (comment == null) 
            {
                return NotFound();
            }

            return Ok(comment.Default());
        }
    }
}
