using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dijital_asistan.Entities
{
    public class HatirlaticiTipi
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int HatirlaticiTipiId { get; set; }

        [Required]
        [StringLength(100)]
        public string HatirlaticiTipiAdi { get; set; }

        [Required]
        [StringLength(200)]
        public string Baslik { get; set; }

        [Required]
        public DateTime HatirlaticiTarihi { get; set; }

        // Navigation property (Bire-Çok İlişki)
        public virtual ICollection<Hatirlaticilar> Hatirlaticilar { get; set; } = new List<Hatirlaticilar>();
    }
}
