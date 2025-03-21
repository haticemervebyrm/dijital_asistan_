using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dijital_asistan.Entities
{
    public class Tavsiyeler
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TavsiyeId { get; set; }

        [Required]
        [ForeignKey("Kullanici")]
        public int KullaniciId { get; set; }

        [Required]
        public string TavsiyeMetni { get; set; }

        [Required]
        public DateTime Tarih { get; set; } = DateTime.UtcNow;

        // Navigation property
        public virtual Kullanici Kullanici { get; set; }
    }
}
