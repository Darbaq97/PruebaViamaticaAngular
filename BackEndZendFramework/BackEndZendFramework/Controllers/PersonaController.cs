using BackEndZendFramework.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackEndZendFramework.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {

        private readonly AplicationDbContext _context;

        public PersonaController(AplicationDbContext context)
        {
            _context = context;
        }



        // GET: api/<TarjetaController>
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            try
            {
                var listTarjetas = await _context.DBPersona.ToListAsync();
                return Ok(listTarjetas);
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
                var persona = await _context.DBPersona.FindAsync(id);
                if (persona == null)
                {
                    return NotFound();
                }
                return Ok(persona);
            }
            catch (Exception ms)
            {

                return BadRequest(ms.Message);
            }
        }



        // POST api/<PersonaController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Persona persona)
        {
            try
            {
                _context.Add(persona);
                await _context.SaveChangesAsync();
                return Ok(persona);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }
        }

        // PUT api/<PersonaController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] Persona persona)
        {
            try
            {
                if (id != persona.Id) {
                    return NotFound();
                }
                _context.Update(persona);
                await _context.SaveChangesAsync();
                return Ok(new { message= "La persona fue actualizada con exito!" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }
        }

        // DELETE api/<TarjetaController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                var tarjeta = await _context.DBPersona.FindAsync(id);
                if (tarjeta == null)
                {
                    return NotFound();

                }
                _context.DBPersona.Remove(tarjeta);
                await _context.SaveChangesAsync();
                return Ok(new { message = "La Persona fue eliminada con exito" });
            }
            catch (Exception ms)
            {

                return BadRequest(ms.Message);
            }
        }
    }
}
