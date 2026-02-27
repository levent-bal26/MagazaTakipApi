using System.ComponentModel.DataAnnotations;

namespace MagazaTakipApi.Models;
public class Beden

{
public int BedenId { get; set; }                     // PK

[Required]
public string BedenAdi { get; set; } = string.Empty;  

	
}


