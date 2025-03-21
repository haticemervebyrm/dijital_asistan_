using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dijital_asistan.Entities
{
    public class DegerTipi
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DegerTipiId { get; set; }

        [Required]
        [MaxLength(100)]
        public string DegerTipiAdi { get; set; }

        // Navigation property
        public virtual ICollection<Degerler> Degerler { get; set; } = new HashSet<Degerler>();
    }
}
