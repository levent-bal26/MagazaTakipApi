using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MagazaTakipApi.Data;
using MagazaTakipApi.Models;
using MagazaTakipApi.Dtos.Firma;

namespace MagazaTakipApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FirmaController : ControllerBase
{
    private readonly AppDbContext _context;

    public FirmaController(AppDbContext context)
    {
        _context = context;
    }

    // GET: api/Firma
    [HttpGet]
    public async Task<ActionResult<List<FirmaListDto>>> GetAll()
    {
        var list = await _context.Firmalar
            .AsNoTracking()
            .Select(f => new FirmaListDto
            {
                FirmaId = f.FirmaId,
                FirmaAdi = f.FirmaAdi,
                FirmaTel = f.FirmaTel,
                FirmaAdres = f.FirmaAdres
            })
            .ToListAsync();

        return Ok(list);
    }

    // GET: api/Firma/5
    [HttpGet("{id:int}")]
    public async Task<ActionResult<FirmaListDto>> GetById(int id)
    {
        var entity = await _context.Firmalar
            .AsNoTracking()
            .FirstOrDefaultAsync(f => f.FirmaId == id);

        if (entity is null)
            return NotFound();

        var dto = new FirmaListDto
        {
            FirmaId = entity.FirmaId,
            FirmaAdi = entity.FirmaAdi,
            FirmaTel = entity.FirmaTel,
            FirmaAdres = entity.FirmaAdres
        };

        return Ok(dto);
    }

    // POST: api/Firma
    [HttpPost]
    public async Task<ActionResult<FirmaListDto>> Create([FromBody] FirmaCreateDto dto)
    {
        var entity = new Firma
        {
            FirmaAdi = dto.FirmaAdi,
            FirmaTel = dto.FirmaTel,
            FirmaAdres = dto.FirmaAdres
        };

        _context.Firmalar.Add(entity);
        await _context.SaveChangesAsync();

        var result = new FirmaListDto
        {
            FirmaId = entity.FirmaId,
            FirmaAdi = entity.FirmaAdi,
            FirmaTel = entity.FirmaTel,
            FirmaAdres = entity.FirmaAdres
        };

        return CreatedAtAction(nameof(GetById), new { id = entity.FirmaId }, result);
    }

    // PUT: api/Firma/5
    [HttpPut("{id:int}")]
    public async Task<IActionResult> Update(int id, [FromBody] FirmaUpdateDto dto)
    {
        var entity = await _context.Firmalar.FirstOrDefaultAsync(f => f.FirmaId == id);
        if (entity is null)
            return NotFound();

        entity.FirmaAdi = dto.FirmaAdi;
        entity.FirmaTel = dto.FirmaTel;
        entity.FirmaAdres = dto.FirmaAdres;

        await _context.SaveChangesAsync();
        return NoContent();
    }

    // DELETE: api/Firma/5
    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        var entity = await _context.Firmalar.FirstOrDefaultAsync(f => f.FirmaId == id);
        if (entity is null)
            return NotFound();

        _context.Firmalar.Remove(entity);
        await _context.SaveChangesAsync();

        return NoContent();
    }
}