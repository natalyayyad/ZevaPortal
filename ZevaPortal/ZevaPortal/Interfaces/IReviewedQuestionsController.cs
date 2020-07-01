using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using ZevaPortal.Models;

namespace ZevaPortal.Interfaces
{
    public interface IReviewedQuestionsController
    {
        Task<ActionResult<ReviewedQuestion>> DeleteReviewedQuestion(int id);
        Task<ActionResult<ReviewedQuestion>> GetReviewedQuestion(int id);
        Task<ActionResult<IEnumerable<ReviewedQuestion>>> GetReviewedQuestions();
        Task<ActionResult<ReviewedQuestion>> PostReviewedQuestion(ReviewedQuestion reviewedQuestion);
        Task<IActionResult> PutReviewedQuestion(int id, ReviewedQuestion reviewedQuestion);
    }
}