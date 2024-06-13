﻿using API_F_CS.Data;
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
    }
}
