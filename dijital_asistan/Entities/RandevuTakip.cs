using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dijital_asistan.Entities
{
    public class RandevuTakip
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RandevuId { get; set; }

        [Required]
        [ForeignKey("Kullanici")]
        public int KullaniciId { get; set; }

        [Required]
        public DateTime RandevuTarihi { get; set; }

        [Required]
        [MaxLength(100)]
        public string DoktorAdi { get; set; }

        [MaxLength(500)]
        public string Notlar { get; set; }

        // Navigation property
        public virtual Kullanici Kullanici { get; set; }
    }
}
