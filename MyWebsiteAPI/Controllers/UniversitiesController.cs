using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyWebsiteAPI.Datas;
using MyWebsiteAPI.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebsiteAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UniversitiesController : ControllerBase
    {
        private readonly ManageDBContext _context;
        public UniversitiesController(ManageDBContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<University>>> GetPaymentDetails()
        {
            return await _context.Universities.ToListAsync();
        }

        // GET: api/University/1
        [HttpGet("{id}")]
        public async Task<ActionResult<University>> GetUniversityItem(int id)
        {
            var University = await _context.Universities.FindAsync(id);

            if (University == null)
            {
                return NotFound();
            }
            return University;
        }
        // PUT: api/TodoItems/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUniversity(int id, University university)
        {
            if (id != university.ID)
            {
                return BadRequest();
            }

            _context.Entry(university).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UniversityExists(id))
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
        bool UniversityExists(int ID)
        {
            var University = _context.Universities.FindAsync(ID);

            if (University == null)
            {
                return false;
            }
            return true;
        }
    }
}
