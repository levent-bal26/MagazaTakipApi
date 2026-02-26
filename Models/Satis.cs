using System.ComponentModel.DataAnnotations;
namespace MagazaTakipApi.Models;
public class Satis
{
public int SatisHareketId { get; set; }     	// PK
public int MusteriId { get; set; }              //FK1
public int PersonelId { get; set; }   		   
public DateTime SatisTar { get; set; }

[Required]
public string SatisMiktar { get; set; } = string.Empty;

[Required]
public string SatisBirimi { get; set; } = string.Empty;
public decimal SatisFiyati { get; set; }
public int UrunId { get; set; }                 // FK2 -> UrunId

}