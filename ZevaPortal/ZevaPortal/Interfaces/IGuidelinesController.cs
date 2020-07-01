using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using ZevaPortal.Models;

namespace ZevaPortal.Interfaces
{
    public interface IGuidelinesController
    {
        Task<ActionResult<Guideline>> DeleteGuideline(int id);
        Task<ActionResult<Guideline>> GetGuideline(int id);
        Task<ActionResult<IEnumerable<Guideline>>> GetGuidelines();
        Task<ActionResult<Guideline>> PostGuideline(Guideline guideline);
        Task<IActionResult> PutGuideline(int id, Guideline guideline);
    }
}