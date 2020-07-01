using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZevaPortal.Interfaces;
using ZevaPortal.Models;

namespace ZevaPortal.Implement_Interfaces
{
    public class Guidlines : IGuidelinesController
    {
        public Task<ActionResult<Guideline>> DeleteGuideline(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<Guideline>> GetGuideline(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<IEnumerable<Guideline>>> GetGuidelines()
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<Guideline>> PostGuideline(Guideline guideline)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> PutGuideline(int id, Guideline guideline)
        {
            throw new NotImplementedException();
        }
    }
}
