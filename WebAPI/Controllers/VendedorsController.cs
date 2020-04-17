using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPI.Controllers
{

    
    [Route("api/[controller]")]
    [ApiController]
  
    public class VendedorsController : ControllerBase
    {
        private readonly VendedorContext _context;

        public VendedorsController(VendedorContext context)
        {
            _context = context;
        }
       
        // GET: api/Vendedors
        [HttpGet]
        public IEnumerable<Vendedor> GetVendedores()
        {
            return _context.Vendedores;
        }

        // GET: api/Vendedors/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetVendedor([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var vendedor = await _context.Vendedores.FindAsync(id);

            if (vendedor == null)
            {
                return NotFound();
            }

            return Ok(vendedor);
        }

        // PUT: api/Vendedors/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVendedor([FromRoute] int id, [FromBody] Vendedor vendedor)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != vendedor.Codigo)
            {
                return BadRequest();
            }

            _context.Entry(vendedor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VendedorExists(id))
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

        // POST: api/Vendedors
        [HttpPost]
        public async Task<IActionResult> PostVendedor([FromBody] Vendedor vendedor)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Vendedores.Add(vendedor);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVendedor", new { id = vendedor.Codigo }, vendedor);
        }

        // DELETE: api/Vendedors/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVendedor([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var vendedor = await _context.Vendedores.FindAsync(id);
            if (vendedor == null)
            {
                return NotFound();
            }

            _context.Vendedores.Remove(vendedor);
            await _context.SaveChangesAsync();

            return Ok(vendedor);
        }

        private bool VendedorExists(int id)
        {
            return _context.Vendedores.Any(e => e.Codigo == id);
        }
    }
}