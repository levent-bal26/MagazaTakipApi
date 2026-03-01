using System.ComponentModel.DataAnnotations;

namespace MagazaTakipApi.Models;

public class Personel
{
    public int PersonelId { get; set; } // PK

    public int IsyeriId { get; set; } // FK -> Isyeri.IsyeriId
    public int PersonelTurId { get; set; } // FK -> PersonelTur.PersonelTurId

    [Required]
    public string PersonelAdi { get; set; } = string.Empty;

    [Required]
    public string PersonelSoyad { get; set; } = string.Empty;

    [Required]
    public string PersonelTel { get; set; } = string.Empty;

    [Required]
    public string PersonelAdres { get; set; } = string.Empty;
}