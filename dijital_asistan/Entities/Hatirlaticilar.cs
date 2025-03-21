using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dijital_asistan.Entities
{
    public class Hatirlaticilar
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int HatirlaticiId { get; set; }

        [Required]
        public int KullaniciId { get; set; }

        [Required]
        public int HatirlaticiTipiId { get; set; }

        // Foreign Key Tanımlamaları
        [ForeignKey("KullaniciId")]
        public virtual Kullanici Kullanici { get; set; }

        [ForeignKey("HatirlaticiTipiId")]
        public virtual HatirlaticiTipi HatirlaticiTipi { get; set; }
    }
}
