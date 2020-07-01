using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ZevaPortal.Interfaces;
using ZevaPortal.Models;

namespace ZevaPortal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExtraInformationsController : ControllerBase, IExtraInformationsController
    {
        private readonly ZevaPortalDbContext _context;

        public ExtraInformationsController(ZevaPortalDbContext context)
        {
            _context = context;
        }

        // GET: api/ExtraInformations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ExtraInformation>>> GetExtraInformation()
        {
            return await _context.ExtraInformation.ToListAsync();
        }

        // GET: api/ExtraInformations/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ExtraInformation>> GetExtraInformation(int id)
        {
            var extraInformation = await _context.ExtraInformation.FindAsync(id);

            if (extraInformation == null)
            {
                return NotFound();
            }

            return extraInformation;
        }

        // PUT: api/ExtraInformations/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutExtraInformation(int id, ExtraInformation extraInformation)
        {
            if (id != extraInformation.ExtraInformationId)
            {
                return BadRequest();
            }

            _context.Entry(extraInformation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExtraInformationExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/ExtraInformations
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ExtraInformation>> PostExtraInformation(ExtraInformation extraInformation)
        {
            _context.ExtraInformation.Add(extraInformation);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetExtraInformation", new { id = extraInformation.ExtraInformationId }, extraInformation);
        }

        // DELETE: api/ExtraInformations/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ExtraInformation>> DeleteExtraInformation(int id)
        {
            var extraInformation = await _context.ExtraInformation.FindAsync(id);
            if (extraInformation == null)
            {
                return NotFound();
            }

            _context.ExtraInformation.Remove(extraInformation);
            await _context.SaveChangesAsync();

            return extraInformation;
        }

        private bool ExtraInformationExists(int id)
        {
            return _context.ExtraInformation.Any(e => e.ExtraInformationId == id);
        }
    }
}
