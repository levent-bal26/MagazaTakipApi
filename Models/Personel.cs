using System.ComponentModel.DataAnnotations;
namespace MagazaTakipApi.Models;
public class Personel

{

public int IsyeriId { get; set; }     		    // PK - FK3

public int PersonelId { get; set; }     		    // PK

[Required]
public string PersonelAdi { get; set; } = string.Empty;  

[Required]
public string PersonelSoyad { get; set; } = string.Empty;  

[Required]
public string PersonelTel { get; set; } = string.Empty; 

[Required]
public string PersonelAdres { get; set; } = string.Empty; 

public int SatisHareketId { get; set; }     	// FK1 -> SatisHareketId

public int PersonelTurId { get; set; }          // FK2

}