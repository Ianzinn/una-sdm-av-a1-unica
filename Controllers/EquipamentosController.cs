using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ValeAtivos324153108.Data;
using ValeAtivos324153108.Models;

namespace ValeAtivos324153108.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EquipamentosController(AppDbContext context) : ControllerBase
    {
        [HttpPost]
        public async Task<ActionResult<Equipamento>> Post([FromBody] Equipamento equipamento)
        {
            context.Equipamentos.Add(equipamento);
            await context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetById), new { id = equipamento.Id }, equipamento);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Equipamento>>> GetAll()
        {
            return await context.Equipamentos.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Equipamento>> GetById(int id)
        {
            var equipamento = await context.Equipamentos.FindAsync(id);
            if (equipamento == null)
                return NotFound();
            return equipamento;
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var equipamento = await context.Equipamentos.FindAsync(id);
            if (equipamento == null)
                return NotFound();
            context.Equipamentos.Remove(equipamento);
            await context.SaveChangesAsync();
            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Equipamento equipamento)
        {
            if (id != equipamento.Id)
                return BadRequest();
            context.Entry(equipamento).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return NoContent();
        }
    }
}