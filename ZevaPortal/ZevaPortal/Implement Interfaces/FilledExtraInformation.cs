using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZevaPortal.Interfaces;

namespace ZevaPortal.Implement_Interfaces
{
    public class FilledExtraInformation : IFilledExtraInformationsController
    {
        public Task<ActionResult<Models.FilledExtraInformation>> DeleteFilledExtraInformation(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<IEnumerable<Models.FilledExtraInformation>>> GetFilledExtraInformation()
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<Models.FilledExtraInformation>> GetFilledExtraInformation(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<Models.FilledExtraInformation>> PostFilledExtraInformation(Models.FilledExtraInformation filledExtraInformation)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> PutFilledExtraInformation(int id, Models.FilledExtraInformation filledExtraInformation)
        {
            throw new NotImplementedException();
        }
    }
}
