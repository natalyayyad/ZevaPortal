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
    public class GuidelinesController : ControllerBase, IGuidelinesController
    {
        private readonly ZevaPortalDbContext _context;

        public GuidelinesController(ZevaPortalDbContext context)
        {
            _context = context;
        }

        // GET: api/Guidelines
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Guideline>>> GetGuidelines()
        {
            return await _context.Guidelines.ToListAsync();
        }

        // GET: api/Guidelines/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Guideline>> GetGuideline(int id)
        {
            var guideline = await _context.Guidelines.FindAsync(id);

            if (guideline == null)
            {
                return NotFound();
            }

            return guideline;
        }

        // PUT: api/Guidelines/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGuideline(int id, Guideline guideline)
        {
            if (id != guideline.GuidelineId)
            {
                return BadRequest();
            }

            _context.Entry(guideline).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GuidelineExists(id))
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

        // POST: api/Guidelines
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Guideline>> PostGuideline(Guideline guideline)
        {
            _context.Guidelines.Add(guideline);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGuideline", new { id = guideline.GuidelineId }, guideline);
        }

        // DELETE: api/Guidelines/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Guideline>> DeleteGuideline(int id)
        {
            var guideline = await _context.Guidelines.FindAsync(id);
            if (guideline == null)
            {
                return NotFound();
            }

            _context.Guidelines.Remove(guideline);
            await _context.SaveChangesAsync();

            return guideline;
        }

        private bool GuidelineExists(int id)
        {
            return _context.Guidelines.Any(e => e.GuidelineId == id);
        }
    }
}
