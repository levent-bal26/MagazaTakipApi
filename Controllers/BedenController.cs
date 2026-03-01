using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MagazaTakipApi.Data;
using MagazaTakipApi.Models;
using MagazaTakipApi.Dtos.Beden;

namespace MagazaTakipApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BedenController : ControllerBase
{
    private readonly AppDbContext _context;

    public BedenController(AppDbContext context)
    {
        _context = context;
    }

    // GET: api/Beden
    [HttpGet]
    public async Task<ActionResult<List<BedenListDto>>> GetAll()
    {
        var list = await _context.Bedenler
            .AsNoTracking()
            .Select(b => new BedenListDto
            {
                BedenId = b.BedenId,
                BedenAdi = b.BedenAdi
            })
            .ToListAsync();

        return Ok(list);
    }

    // GET: api/Beden/5
    [HttpGet("{id:int}")]
    public async Task<ActionResult<BedenListDto>> GetById(int id)
    {
        var entity = await _context.Bedenler
            .AsNoTracking()
            .FirstOrDefaultAsync(b => b.BedenId == id);

        if (entity is null)
            return NotFound();

        var dto = new BedenListDto
        {
            BedenId = entity.BedenId,
            BedenAdi = entity.BedenAdi
        };

        return Ok(dto);
    }

    // POST: api/Beden
    [HttpPost]
    public async Task<ActionResult<BedenListDto>> Create([FromBody] BedenCreateDto dto)
    {
        // [ApiController] olduğu için ModelState otomatik kontrol edilir.

        var entity = new Beden
        {
            BedenAdi = dto.BedenAdi
        };

        _context.Bedenler.Add(entity);
        await _context.SaveChangesAsync();

        var result = new BedenListDto
        {
            BedenId = entity.BedenId,
            BedenAdi = entity.BedenAdi
        };

        return CreatedAtAction(nameof(GetById), new { id = entity.BedenId }, result);
    }

    // PUT: api/Beden/5
    [HttpPut("{id:int}")]
    public async Task<IActionResult> Update(int id, [FromBody] BedenUpdateDto dto)
    {
        var entity = await _context.Bedenler.FirstOrDefaultAsync(b => b.BedenId == id);
        if (entity is null)
            return NotFound();

        entity.BedenAdi = dto.BedenAdi;

        await _context.SaveChangesAsync();
        return NoContent();
    }

    // DELETE: api/Beden/5
    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        var entity = await _context.Bedenler.FirstOrDefaultAsync(b => b.BedenId == id);
        if (entity is null)
            return NotFound();

        _context.Bedenler.Remove(entity);
        await _context.SaveChangesAsync();

        return NoContent();
    }
}