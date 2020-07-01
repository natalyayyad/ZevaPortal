using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZevaPortal.Interfaces;
using ZevaPortal.Models;

namespace ZevaPortal.Implement_Interfaces
{
    public class ReviewedCategories : IReviewedCategoriesController
    {
        public Task<ActionResult<ReviewedCategory>> DeleteReviewedCategory(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<IEnumerable<ReviewedCategory>>> GetReviewedCategories()
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<ReviewedCategory>> GetReviewedCategory(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<ReviewedCategory>> PostReviewedCategory(ReviewedCategory reviewedCategory)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> PutReviewedCategory(int id, ReviewedCategory reviewedCategory)
        {
            throw new NotImplementedException();
        }
    }
}
