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
    public class FilledExtraInformationsController : ControllerBase, IFilledExtraInformationsController
    {
        private readonly ZevaPortalDbContext _context;

        public FilledExtraInformationsController(ZevaPortalDbContext context)
        {
            _context = context;
        }

        // GET: api/FilledExtraInformations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FilledExtraInformation>>> GetFilledExtraInformation()
        {
            return await _context.FilledExtraInformation.ToListAsync();
        }

        // GET: api/FilledExtraInformations/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FilledExtraInformation>> GetFilledExtraInformation(int id)
        {
            var filledExtraInformation = await _context.FilledExtraInformation.FindAsync(id);

            if (filledExtraInformation == null)
            {
                return NotFound();
            }

            return filledExtraInformation;
        }

        // PUT: api/FilledExtraInformations/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFilledExtraInformation(int id, FilledExtraInformation filledExtraInformation)
        {
            if (id != filledExtraInformation.FilledExtraInformationId)
            {
                return BadRequest();
            }

            _context.Entry(filledExtraInformation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FilledExtraInformationExists(id))
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

        // POST: api/FilledExtraInformations
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<FilledExtraInformation>> PostFilledExtraInformation(FilledExtraInformation filledExtraInformation)
        {
            _context.FilledExtraInformation.Add(filledExtraInformation);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFilledExtraInformation", new { id = filledExtraInformation.FilledExtraInformationId }, filledExtraInformation);
        }

        // DELETE: api/FilledExtraInformations/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<FilledExtraInformation>> DeleteFilledExtraInformation(int id)
        {
            var filledExtraInformation = await _context.FilledExtraInformation.FindAsync(id);
            if (filledExtraInformation == null)
            {
                return NotFound();
            }

            _context.FilledExtraInformation.Remove(filledExtraInformation);
            await _context.SaveChangesAsync();

            return filledExtraInformation;
        }

        private bool FilledExtraInformationExists(int id)
        {
            return _context.FilledExtraInformation.Any(e => e.FilledExtraInformationId == id);
        }
    }
}
