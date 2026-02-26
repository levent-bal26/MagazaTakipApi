using System.ComponentModel.DataAnnotations;
namespace MagazaTakipApi.Models;
public class Isyeri

{

public int IsyeriId { get; set; }     		    // PK

[Required]
public string IsyeriAdi { get; set; } = string.Empty;

[Required]
public string IsyeriAdres { get; set; }= string.Empty; 

[Required]
public string IsyeriTel { get; set; } = string.Empty; 

} 