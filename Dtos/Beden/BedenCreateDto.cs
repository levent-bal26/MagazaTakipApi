using System.ComponentModel.DataAnnotations;
namespace MagazaTakipApi.Dtos.Beden;
public class BedenCreateDto
{
[Required]
public string BedenAdi { get; set; } = string.Empty;
}
