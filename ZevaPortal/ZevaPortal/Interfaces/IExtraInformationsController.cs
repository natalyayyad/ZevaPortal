using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using ZevaPortal.Models;

namespace ZevaPortal.Interfaces
{
    public interface IExtraInformationsController
    {
        Task<ActionResult<ExtraInformation>> DeleteExtraInformation(int id);
        Task<ActionResult<IEnumerable<ExtraInformation>>> GetExtraInformation();
        Task<ActionResult<ExtraInformation>> GetExtraInformation(int id);
        Task<ActionResult<ExtraInformation>> PostExtraInformation(ExtraInformation extraInformation);
        Task<IActionResult> PutExtraInformation(int id, ExtraInformation extraInformation);
    }
}