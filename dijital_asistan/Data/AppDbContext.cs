using Microsoft.EntityFrameworkCore;
using dijital_asistan.Entities;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;


namespace dijital_asistan.Data
{
    using dijital_asistan.Model;

    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Kullanici> Kullanici { get; set; }
        public DbSet<Ilac> Ilaclar { get; set; }
        public DbSet<Besin> Besin { get; set; }
        public DbSet<RandevuTakip> RandevuTakipler { get; set; }
        public DbSet<Tavsiyeler> Tavsiyeler { get; set; }
        public DbSet<HatirlaticiTipi> HatirlaticiTipi { get; set; }
        public DbSet<Hatirlaticilar> Hatirlaticilar { get; set; }
        public DbSet<SensorVeri> SensorVeri { get; set; }
        public DbSet<SensorVeriTipi> SensorVeriTipi { get; set; }
        public DbSet<Aksesuar> Aksesuar { get; set; }
        public DbSet<DegerTipi> DegerTipi { get; set; }
        public DbSet<Degerler> Degerler { get; set; }
        public DbSet<Rapor> Rapor { get; set; }
        public DbSet<YapayZekaAnaliz> YapayZekaAnaliz { get; set; }
        public DbSet<YapayZekaAnalizTipi> YapayZekaAnalizTipi { get; set; }

    }
}
