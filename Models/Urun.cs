using System.ComponentModel.DataAnnotations;
namespace MagazaTakipApi.Models;
public class Urun

{
public int UrunId { get; set; }                     // PK
public int FirmaId { get; set; }                    // FK1 -> FirmaId
public int BedenId { get; set; }                     // PK

[Required]
public string UrunAdi { get; set; } = string.Empty;  // FK1 
public int ModelNo { get; set; }                     // FK1 
	
}