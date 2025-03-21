using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dijital_asistan.Entities
{
    public class Besin
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BesinId { get; set; }

        [Required]
        [ForeignKey("Kullanici")]
        public int KullaniciId { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Kalori değeri negatif olamaz.")]
        public int Kalori { get; set; }

        [Required]
        [MaxLength(100)]
        public string Kategori { get; set; }

        [Required]
        [Range(0, float.MaxValue, ErrorMessage = "Karbonhidrat miktarı negatif olamaz.")]
        public float Karbonhidrat { get; set; }

        [Required]
        [Range(0, float.MaxValue, ErrorMessage = "Protein miktarı negatif olamaz.")]
        public float Protein { get; set; }

        [Required]
        [Range(0, float.MaxValue, ErrorMessage = "Yağ miktarı negatif olamaz.")]
        public float Yag { get; set; }

        [Required]
        public DateTime Tarih { get; set; } = DateTime.Now; // Varsayılan olarak bugünün tarihi

        // Navigation property
        public virtual Kullanici Kullanici { get; set; }
    }
}
