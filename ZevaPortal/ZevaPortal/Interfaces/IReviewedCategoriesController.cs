using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using ZevaPortal.Models;

namespace ZevaPortal.Interfaces
{
    public interface IReviewedCategoriesController
    {
        Task<ActionResult<ReviewedCategory>> DeleteReviewedCategory(int id);
        Task<ActionResult<IEnumerable<ReviewedCategory>>> GetReviewedCategories();
        Task<ActionResult<ReviewedCategory>> GetReviewedCategory(int id);
        Task<ActionResult<ReviewedCategory>> PostReviewedCategory(ReviewedCategory reviewedCategory);
        Task<IActionResult> PutReviewedCategory(int id, ReviewedCategory reviewedCategory);
    }
}