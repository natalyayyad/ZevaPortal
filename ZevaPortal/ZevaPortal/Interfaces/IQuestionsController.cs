using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using ZevaPortal.Models;

namespace ZevaPortal.Interfaces
{
    public interface IQuestionsController
    {
        Task<ActionResult<Question>> DeleteQuestion(int id);
        Task<ActionResult<Question>> GetQuestion(int id);
        Task<ActionResult<IEnumerable<Question>>> GetQuestions();
        Task<ActionResult<Question>> PostQuestion(Question question);
        Task<IActionResult> PutQuestion(int id, Question question);
    }
}