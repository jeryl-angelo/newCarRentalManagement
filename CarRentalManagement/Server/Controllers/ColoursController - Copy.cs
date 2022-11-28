using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CarRentalManagement.Server.Data;
using CarRentalManagement.Shared.Domain;
using CarRentalManagement.Server.IRepository;

namespace CarRentalManagement.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColoursController : ControllerBase
    {
        //private object unitOfWork;

        //Refractored
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

       // public ColoursController(ApplicationDbContext context)
        public ColoursController(IUnitOfWork unitOfWork)
        {
            //Refacted
            //_context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/Colours
        [HttpGet]
        //Refacted
        //public async Task<ActionResult<IEnumerable<Colour>>> GetColours()
        public async Task<IActionResult> GetColours()
        {
            //return await _context.Colours.ToListAsync();
            //Refacted
            var makes = await _unitOfWork.Colours.GetAll();
            return Ok(makes);
        }

        // GET: api/Colours/5
        [HttpGet("{id}")]
        //public async Task<ActionResult<Colour>> GetColour(int id)
        public async Task<IActionResult> GetColour (int id )
        {
            //var make = await _context.Colours.FindAsync(id);
            var make = await _unitOfWork.Colours.Get(q => q.Id == id);

            if (make == null)
            {
                return NotFound();
            }

            //return make;
            return Ok(make);
        }

        // PUT: api/Colours/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutColour(int id, Colour make)
        {
            if (id != make.Id)
            {
                return BadRequest();
            }

            //_context.Entry(make).State = EntityState.Modified;
            _unitOfWork.Colours.Update(make);

            try
            {
                // await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (id!=make.Id)
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

        // POST: api/Colours
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Colour>> PostColour(Colour make)
        {
            // _context.Colours.Add(make);
            // await _context.SaveChangesAsync();
            await _unitOfWork.Colours.Insert(make);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetColour", new { id = make.Id }, make);
        }

        // DELETE: api/Colours/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteColour(int id)
        {
            //var make = await _context.Colours.FindAsync(id);

            var make = await _unitOfWork.Colours.Get(q => q.Id == id);
            if (make == null)
            {
                return NotFound();
            }

            //_context.Colours.Remove(make);
            //await _context.SaveChangesAsync();

            await _unitOfWork.Colours.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> ColourExists(int id)
        {
            // return _context.Colours.Any(e => e.Id == id);
            var make = await _unitOfWork.Colours.Get(q => q.Id == id);
            return make != null;
        }
    }
}
