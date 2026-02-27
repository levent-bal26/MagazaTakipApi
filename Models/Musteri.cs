using System.ComponentModel.DataAnnotations;
namespace MagazaTakipApi.Models;
public class Musteri
{
public int MusteriId { get; set; }     		    // PK

[Required]
public string MusteriAdi { get; set; } = string.Empty;  

[Required]
public string MusteriSoyad { get; set; } = string.Empty;  

[Required]
public string MusteriTel { get; set; } = string.Empty; 

[Required]
public string MusteriAdres { get; set; } = string.Empty; 


}