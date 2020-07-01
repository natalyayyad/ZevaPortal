using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZevaPortal.Interfaces;
using ZevaPortal.Models;

namespace ZevaPortal.Implement_Interfaces
{
    public class ReviewedQuestions : IReviewedQuestionsController
    {
        public Task<ActionResult<ReviewedQuestion>> DeleteReviewedQuestion(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<ReviewedQuestion>> GetReviewedQuestion(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<IEnumerable<ReviewedQuestion>>> GetReviewedQuestions()
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<ReviewedQuestion>> PostReviewedQuestion(ReviewedQuestion reviewedQuestion)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> PutReviewedQuestion(int id, ReviewedQuestion reviewedQuestion)
        {
            throw new NotImplementedException();
        }
    }
}
