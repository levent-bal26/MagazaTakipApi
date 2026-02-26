using System.ComponentModel.DataAnnotations;

namespace MagazaTakipApi.Models;
public class DepoGiris
{
public int DepoGirisId { get; set; }            // PK
public int UrunId { get; set; }                 // FK1 -> UrunId
public int SatisHareketId { get; set; }     	// FK5 -> SatisHareketId
public int FirmaId { get; set; }     		    // FK3 -> FirmaId
public int İsyeriId { get; set; }     		    // FK2 -> İsyeriId
public int PersonelId { get; set; }     	    // FK2 -> PersonelId
public DateTime GelisTar { get; set; }
[Required]
public string GelisMiktar { get; set; } = string.Empty;
[Required]
public string GelisBirimi { get; set; } = string.Empty;
public decimal AlisFiyati { get; set; }

	
}


