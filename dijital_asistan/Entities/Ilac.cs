using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dijital_asistan.Entities
{
    public class Ilac
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IlacId { get; set; }

        [Required]
        [StringLength(150)]
        public string IlacAd { get; set; }

        [Required]
        [StringLength(50)]
        public string Dozaj { get; set; }

        [Required]
        public DateTime BaslangicTarih { get; set; }

        [Required]
        public DateTime BitisTarihi { get; set; }

        [Required]
        public bool AlindiMi { get; set; } = false; // Varsayılan değer false (İlaç alınmadı)

        // Kullanıcı ile ilişkilendirme
        [ForeignKey("Kullanici")]
        public int KullaniciId { get; set; }
        public virtual Kullanici Kullanici { get; set; }
    }
}
