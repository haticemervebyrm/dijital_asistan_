using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dijital_asistan.Entities
{
    public class Kullanici
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int KullaniciId { get; set; }

        [Required]
        [MaxLength(100)]
        public string KullaniciAdi { get; set; }

        [Required]
        [MaxLength(255)]
        public string SifreHash { get; set; }

        public int? Yas { get; set; }

        [MaxLength(10)] // "Erkek", "Kadın", "Diğer" gibi kısa ifadeler için
        public string Cinsiyet { get; set; }

        [Required]
        [EmailAddress]
        public string Eposta { get; set; }

        public bool EpostaDogrulandi { get; set; } = false;

        public DateTime? EpostaDogrulamaTarihi { get; set; }

        [Required]
        [MaxLength(20)]
        public string Durum { get; set; } = "pasif";

        [Required]
        public DateTime OlusturulmaTarihi { get; set; } = DateTime.UtcNow;

        // Navigation Properties (İlişkiler)
        public virtual ICollection<Besin> Besinler { get; set; } = new HashSet<Besin>();
        public virtual ICollection<RandevuTakip> Randevular { get; set; } = new HashSet<RandevuTakip>();
        public virtual ICollection<Tavsiyeler> Tavsiyeler { get; set; } = new HashSet<Tavsiyeler>();
        public virtual ICollection<Hatirlaticilar> Hatirlaticilar { get; set; } = new HashSet<Hatirlaticilar>();
        public virtual ICollection<SensorVeri> SensorVerileri { get; set; } = new HashSet<SensorVeri>();
        public virtual ICollection<Aksesuar> Aksesuarlar { get; set; } = new HashSet<Aksesuar>();
        public virtual ICollection<Degerler> Degerler { get; set; } = new HashSet<Degerler>();
        public virtual ICollection<Rapor> Raporlar { get; set; } = new HashSet<Rapor>();
        public virtual ICollection<YapayZekaAnaliz> YapayZekaAnalizler { get; set; } = new HashSet<YapayZekaAnaliz>();
    }
}
