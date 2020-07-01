using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZevaPortal.Interfaces;
using ZevaPortal.Models;

namespace ZevaPortal.Implement_Interfaces
{
    public class ExtraInformations : IExtraInformationsController
    {
        public Task<ActionResult<ExtraInformation>> DeleteExtraInformation(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<IEnumerable<ExtraInformation>>> GetExtraInformation()
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<ExtraInformation>> GetExtraInformation(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<ExtraInformation>> PostExtraInformation(ExtraInformation extraInformation)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> PutExtraInformation(int id, ExtraInformation extraInformation)
        {
            throw new NotImplementedException();
        }
    }
}
