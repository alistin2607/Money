using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Money.DB;

namespace Money.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MonthsController : ControllerBase
    {
        private readonly MoneyDBContext _context;

        public MonthsController(MoneyDBContext context)
        {
            _context = context;
        }

        // GET: api/Months
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Month>>> GetMonths()
        {
            return await _context.Months.ToListAsync();
        }

        // GET: api/Months/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Month>> GetMonth(Guid id)
        {
            var month = await _context.Months.FindAsync(id);

            if (month == null)
            {
                return NotFound();
            }

            return month;
        }

        // PUT: api/Months/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMonth(Guid id, Month month)
        {
            if (id != month.ID)
            {
                return BadRequest();
            }

            _context.Entry(month).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MonthExists(id))
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

        // POST: api/Months
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Month>> PostMonth(Month month)
        {
            _context.Months.Add(month);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMonth", new { id = month.ID }, month);
        }

        // DELETE: api/Months/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Month>> DeleteMonth(Guid id)
        {
            var month = await _context.Months.FindAsync(id);
            if (month == null)
            {
                return NotFound();
            }

            _context.Months.Remove(month);
            await _context.SaveChangesAsync();

            return month;
        }

        private bool MonthExists(Guid id)
        {
            return _context.Months.Any(e => e.ID == id);
        }
    }
}
