using Microsoft.EntityFrameworkCore;

using MagazaTakipApi.Models;

namespace MagazaTakipApi.Data;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Beden> Bedenler => Set<Beden>();

    public DbSet<DepoGiris> DepoGirisler => Set<DepoGiris>();

    public DbSet<Firma> Firmalar => Set<Firma >();

    public DbSet<Isyeri> Isyerleri => Set<Isyeri>();

    public DbSet<Musteri> Musteriler => Set<Musteri>();

    public DbSet<Personel> Personeller => Set<Personel>();

    public DbSet<PersonelTur > PersonelTurler => Set<PersonelTur>();

    public DbSet<Satis> Satislar => Set<Satis>();

    public DbSet<Urun> Urunler => Set<Urun>();    

      
}
