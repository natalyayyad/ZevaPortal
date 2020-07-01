using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZevaPortal.Interfaces;
using ZevaPortal.Models;

namespace ZevaPortal.Implement_Interfaces
{
    public class Questions : IQuestionsController
    {
        public Task<ActionResult<Question>> DeleteQuestion(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<Question>> GetQuestion(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<IEnumerable<Question>>> GetQuestions()
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<Question>> PostQuestion(Question question)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> PutQuestion(int id, Question question)
        {
            throw new NotImplementedException();
        }
    }
}
