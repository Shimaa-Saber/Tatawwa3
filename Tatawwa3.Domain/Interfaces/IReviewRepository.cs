using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Domain.Entities;

namespace Tatawwa3.Domain.Interfaces
{
   public interface IReviewRepository:IGeneric<Review>
    {
        Task<int> CountAsync();
        Task<List<Review>> GetReviewsWithUserByOpportunityIdAsync(string opportunityId);
        Task<List<Review>> GetAllReviewsWithUserAndOpportunityAsync();
        Task<int> CountDeletedReviewsAsync();



    }
}
