using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZevaPortal.Interfaces;
using ZevaPortal.Models;

namespace ZevaPortal.Implement_Interfaces
{
    public class Assessments : IAssessmentsController
    {
        public Task<ActionResult<Assessment>> DeleteAssessment(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<Assessment>> GetAssessment(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<IEnumerable<Assessment>>> GetAssessments()
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<Assessment>> PostAssessment(Assessment assessment)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> PutAssessment(int id, Assessment assessment)
        {
            throw new NotImplementedException();
        }
    }
}
