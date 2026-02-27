using System.ComponentModel.DataAnnotations;
namespace MagazaTakipApi.Models;
public class Firma

{
public int FirmaId { get; set; }                     // PK

[Required]
public string FirmaAdi { get; set; } = string.Empty;

[Required]
public string FirmaTel { get; set; } = string.Empty; 

[Required]
public string FirmaAdres { get; set; }= string.Empty; 
	
}