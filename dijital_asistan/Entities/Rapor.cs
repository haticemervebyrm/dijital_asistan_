using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dijital_asistan.Entities
{
    public class Rapor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RaporId { get; set; }

        [Required]
        [ForeignKey("Kullanici")]
        public int KullaniciId { get; set; }

        [Required]
        public DateTime RaporTarihi { get; set; }

        [Required]
        [MaxLength(1000)]
        public string RaporIcerigi { get; set; }

        // Navigation property
        public virtual Kullanici Kullanici { get; set; }
    }
}
