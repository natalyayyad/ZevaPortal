using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using ZevaPortal.Models;

namespace ZevaPortal.Interfaces
{
    public interface IFormsController
    {
        Task<ActionResult<Form>> DeleteForm(int id);
        Task<ActionResult<Form>> GetForm(int id);
        Task<ActionResult<IEnumerable<Form>>> GetForms();
        Task<ActionResult<Form>> PostForm(Form form);
        Task<IActionResult> PutForm(int id, Form form);
    }
}