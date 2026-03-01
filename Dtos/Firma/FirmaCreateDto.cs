using System.ComponentModel.DataAnnotations;
namespace MagazaTakipApi.Dtos.Firma;
public class FirmaCreateDto
{
    [Required]
    public string FirmaAdi { get; set; } = string.Empty;

    [Required]
    public string FirmaTel { get; set; } = string.Empty;

    [Required]
    public string FirmaAdres { get; set; } = string.Empty;
}
