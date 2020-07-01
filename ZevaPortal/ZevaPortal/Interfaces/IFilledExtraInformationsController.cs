using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using ZevaPortal.Models;

namespace ZevaPortal.Interfaces
{
    public interface IFilledExtraInformationsController
    {
        Task<ActionResult<FilledExtraInformation>> DeleteFilledExtraInformation(int id);
        Task<ActionResult<IEnumerable<FilledExtraInformation>>> GetFilledExtraInformation();
        Task<ActionResult<FilledExtraInformation>> GetFilledExtraInformation(int id);
        Task<ActionResult<FilledExtraInformation>> PostFilledExtraInformation(FilledExtraInformation filledExtraInformation);
        Task<IActionResult> PutFilledExtraInformation(int id, FilledExtraInformation filledExtraInformation);
    }
}