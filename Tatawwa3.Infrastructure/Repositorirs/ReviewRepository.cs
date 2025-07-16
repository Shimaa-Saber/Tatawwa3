using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Domain.Entities;
using Tatawwa3.Domain.Interfaces;
using Tatawwa3.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;


namespace Tatawwa3.Infrastructure.Repositorirs
{
    public class ReviewRepository:GenericRepository<Review>, IReviewRepository
    {
        private readonly Tatawwa3DbContext _context;

        public ReviewRepository(Tatawwa3DbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<int> CountAsync()
        {
            return await _context.Reviews.CountAsync(); // غيّر الاسم لو مختلف
        }
    }
}
