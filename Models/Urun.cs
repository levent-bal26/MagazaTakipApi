using System.ComponentModel.DataAnnotations;

namespace MagazaTakipApi.Models;

public class Urun
{
    public int UrunId { get; set; } // PK

    public int FirmaId { get; set; } // FK -> Firma.FirmaId
    public int BedenId { get; set; } // FK -> Beden.BedenId

    [Required]
    public string UrunAdi { get; set; } = string.Empty;

    public int ModelNo { get; set; }
}