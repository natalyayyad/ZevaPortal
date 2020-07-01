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
    public class ReviewedQuestionsController : ControllerBase, IReviewedQuestionsController
    {
        private readonly ZevaPortalDbContext _context;

        public ReviewedQuestionsController(ZevaPortalDbContext context)
        {
            _context = context;
        }

        // GET: api/ReviewedQuestions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ReviewedQuestion>>> GetReviewedQuestions()
        {
            return await _context.ReviewedQuestions.ToListAsync();
        }

        // GET: api/ReviewedQuestions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ReviewedQuestion>> GetReviewedQuestion(int id)
        {
            var reviewedQuestion = await _context.ReviewedQuestions.FindAsync(id);

            if (reviewedQuestion == null)
            {
                return NotFound();
            }

            return reviewedQuestion;
        }

        // PUT: api/ReviewedQuestions/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutReviewedQuestion(int id, ReviewedQuestion reviewedQuestion)
        {
            if (id != reviewedQuestion.ReviewedQuestionId)
            {
                return BadRequest();
            }

            _context.Entry(reviewedQuestion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ReviewedQuestionExists(id))
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

        // POST: api/ReviewedQuestions
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ReviewedQuestion>> PostReviewedQuestion(ReviewedQuestion reviewedQuestion)
        {
            _context.ReviewedQuestions.Add(reviewedQuestion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetReviewedQuestion", new { id = reviewedQuestion.ReviewedQuestionId }, reviewedQuestion);
        }

        // DELETE: api/ReviewedQuestions/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ReviewedQuestion>> DeleteReviewedQuestion(int id)
        {
            var reviewedQuestion = await _context.ReviewedQuestions.FindAsync(id);
            if (reviewedQuestion == null)
            {
                return NotFound();
            }

            _context.ReviewedQuestions.Remove(reviewedQuestion);
            await _context.SaveChangesAsync();

            return reviewedQuestion;
        }

        private bool ReviewedQuestionExists(int id)
        {
            return _context.ReviewedQuestions.Any(e => e.ReviewedQuestionId == id);
        }
    }
}
