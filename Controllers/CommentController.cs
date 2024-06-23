﻿using API_F_CS.Interfaces;
using API_F_CS.Mappers;
using Microsoft.AspNetCore.Mvc;

namespace API_F_CS.Controllers
{
    [Route("api/Comment")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly ICommentRepository _commentRepo;

        public CommentController(ICommentRepository commentRepo)
        {
            _commentRepo = commentRepo;
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

            return Ok(comment);
        }
    }
}
