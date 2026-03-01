using System.ComponentModel.DataAnnotations;
namespace MagazaTakipApi.Dtos.Beden;
public class BedenUpdateDto
{
[Required]
public string BedenAdi { get; set; } = string.Empty;
}
