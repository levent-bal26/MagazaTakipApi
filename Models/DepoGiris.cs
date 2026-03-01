using System.ComponentModel.DataAnnotations;

namespace MagazaTakipApi.Models;

public class DepoGiris
{
    public int DepoGirisId { get; set; } // PK

    public int UrunId { get; set; } // FK -> Urun.UrunId
    public int FirmaId { get; set; } // FK -> Firma.FirmaId
    public int IsyeriId { get; set; } // FK -> Isyeri.IsyeriId
    public int PersonelId { get; set; } // FK -> Personel.PersonelId

    public int SatisHareketId { get; set; } // FK -> Satis.SatisHareketId (kullanıyorsan)

    public DateTime GelisTar { get; set; }

    [Required]
    public string GelisMiktar { get; set; } = string.Empty;

    [Required]
    public string GelisBirimi { get; set; } = string.Empty;

    public decimal AlisFiyati { get; set; }
}