using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZevaPortal.Interfaces;

namespace ZevaPortal.Interface_Classes
{
    public class Forms : IFormsController
    {
        public Task<ActionResult<Models.Form>> DeleteForm(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<Models.Form>> GetForm(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<IEnumerable<Models.Form>>> GetForms()
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<Models.Form>> PostForm(Models.Form form)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> PutForm(int id, Models.Form form)
        {
            throw new NotImplementedException();
        }
    }
}
