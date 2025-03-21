using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dijital_asistan.Entities
{
    public class SensorVeriTipi
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SensorVeriTipiId { get; set; }

        [Required]
        [MaxLength(100)]
        public string SensorTipi { get; set; }

        [Required]
        public string Veri { get; set; }

        // Navigation property
        public virtual ICollection<SensorVeri> SensorVeriler { get; set; } = new List<SensorVeri>();
    }
}
