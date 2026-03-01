using System.ComponentModel.DataAnnotations;

namespace MagazaTakipApi.Models;

public class Satis
{
    [Key]
    public int SatisHareketId { get; set; } // PK

    public int MusteriId { get; set; }  // FK -> Musteri.MusteriId
    public int PersonelId { get; set; } // FK -> Personel.PersonelId
    public int UrunId { get; set; }     // FK -> Urun.UrunId

    public DateTime SatisTar { get; set; }

    [Required]
    public string SatisMiktar { get; set; } = string.Empty;

    [Required]
    public string SatisBirimi { get; set; } = string.Empty;

    public decimal SatisFiyati { get; set; }
}