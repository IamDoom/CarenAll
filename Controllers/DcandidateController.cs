using System.Linq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CarenAll.Models;
using System.Data;
using System.Reflection.Metadata.Ecma335;



namespace CarenAll.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class  DCandidateController : Controller
    {
        private readonly DataDBContext _context;
        public DCandidateController(DataDBContext context)
        {
            _context = context;
        }

        //Get: api/DCandidate
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DCandidate>>> GetDCandidate()
        {
            return await _context.DCandidates.ToListAsync();
        }

        //get: api/DCandidate/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DCandidate>> GetDCandidate(int id)
        {
            var dCandidate = await _context.DCandidates.FindAsync(id);
            if (dCandidate == null)
            {
                return NotFound();
            }
            return Ok(dCandidate);
        }

        //put: api/DCandidate/5
        // to protect from overposting attacks, please enable the specific proberties you want to bind tp,for
        [HttpPut("{id}")]
        public async Task<IActionResult>PutDCandidate(int id, DCandidate dCandidate)
        {
            dCandidate.id = id;

            _context.Entry(dCandidate).State = EntityState.Modified;  

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DCandidateExists(id))
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

        //Post : api/DCandidate
        [HttpPost]
        public async Task<ActionResult<DCandidate>> PostDCandidate(DCandidate dCandidate)
        {
            _context.DCandidates.Add(dCandidate);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDCandidate", new { id = dCandidate.id }, dCandidate);
        }

        //Delete: api/DCandidate/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<DCandidate>> DeleteDCandidate(int id)
        {
            var dCandidate = await _context.DCandidates.FindAsync(id);
            if(dCandidate == null)
            {
                return NotFound();

            }

            _context.DCandidates.Remove(dCandidate);
            await _context.SaveChangesAsync();

            return dCandidate;
        }
        
        private bool DCandidateExists(int id)
        {
            return _context.DCandidates.Any(e => e.id == id);
        }
    }

}