using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ZevaPortal.Interfaces;
using ZevaPortal.Models;

namespace ZevaPortal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewedCategoriesController : ControllerBase, IReviewedCategoriesController
    {
        private readonly ZevaPortalDbContext _context;

        public ReviewedCategoriesController(ZevaPortalDbContext context)
        {
            _context = context;
        }

        // GET: api/ReviewedCategories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ReviewedCategory>>> GetReviewedCategories()
        {
            return await _context.ReviewedCategories.ToListAsync();
        }

        // GET: api/ReviewedCategories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ReviewedCategory>> GetReviewedCategory(int id)
        {
            var reviewedCategory = await _context.ReviewedCategories.FindAsync(id);

            if (reviewedCategory == null)
            {
                return NotFound();
            }

            return reviewedCategory;
        }

        // PUT: api/ReviewedCategories/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutReviewedCategory(int id, ReviewedCategory reviewedCategory)
        {
            if (id != reviewedCategory.ReviewedCategoryId)
            {
                return BadRequest();
            }

            _context.Entry(reviewedCategory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ReviewedCategoryExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/ReviewedCategories
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ReviewedCategory>> PostReviewedCategory(ReviewedCategory reviewedCategory)
        {
            _context.ReviewedCategories.Add(reviewedCategory);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetReviewedCategory", new { id = reviewedCategory.ReviewedCategoryId }, reviewedCategory);
        }

        // DELETE: api/ReviewedCategories/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ReviewedCategory>> DeleteReviewedCategory(int id)
        {
            var reviewedCategory = await _context.ReviewedCategories.FindAsync(id);
            if (reviewedCategory == null)
            {
                return NotFound();
            }

            _context.ReviewedCategories.Remove(reviewedCategory);
            await _context.SaveChangesAsync();

            return reviewedCategory;
        }

        private bool ReviewedCategoryExists(int id)
        {
            return _context.ReviewedCategories.Any(e => e.ReviewedCategoryId == id);
        }
    }
}
