using System.ComponentModel.DataAnnotations;

namespace MagazaTakipApi.Models;
public class PersonelTur

{
public int PersonelTurId { get; set; }                     // PK

[Required]
public string PersonelTuru { get; set; } = string.Empty;  

	
}