using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndZendFramework.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class SectorController : Controller
    {
        
        private readonly AplicationDbContext _context;

        public SectorController(AplicationDbContext context)
        {
            _context = context;
        }


        // GET: api/<SectorController>
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            try
            {
                var listSector = await _context.Sector.ToListAsync();
                return Ok(listSector);
            }
            catch (Exception ms)
            {

                return BadRequest(ms.Message);
            }
        }
        // GET: api/<TarjetaController>
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            try
            {
                var sector = await _context.Sector.FindAsync(id);
                if (sector == null)
                {
                    return NotFound();
                }
                return Ok(sector);
            }
            catch (Exception ms)
            {

                return BadRequest(ms.Message);
            }
        }
    }
}
