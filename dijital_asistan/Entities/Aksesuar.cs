using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dijital_asistan.Entities
{
    public class Aksesuar
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AksesuarId { get; set; }

        [Required]
        [ForeignKey("Kullanici")]
        public int KullaniciId { get; set; }

        [Required]
        [MaxLength(100)]
        public string AksesuarTipi { get; set; }

        [Required]
        [MaxLength(100)]
        public string Model { get; set; }

        public bool KullanimDurumu { get; set; } = true;

        // Navigation property
        public virtual Kullanici Kullanici { get; set; }
    }
}
