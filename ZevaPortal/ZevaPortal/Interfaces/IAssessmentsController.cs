using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using ZevaPortal.Models;

namespace ZevaPortal.Interfaces
{
    public interface IAssessmentsController
    {
        Task<ActionResult<Assessment>> DeleteAssessment(int id);
        Task<ActionResult<Assessment>> GetAssessment(int id);
        Task<ActionResult<IEnumerable<Assessment>>> GetAssessments();
        Task<ActionResult<Assessment>> PostAssessment(Assessment assessment);
        Task<IActionResult> PutAssessment(int id, Assessment assessment);
    }
}