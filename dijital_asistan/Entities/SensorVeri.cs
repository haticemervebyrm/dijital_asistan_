using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dijital_asistan.Entities
{
    public class SensorVeri
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SensorVeriId { get; set; }

        [Required]
        [ForeignKey("Kullanici")]
        public int KullaniciId { get; set; }

        [Required]
        [ForeignKey("SensorVeriTipi")]
        public int SensorVeriTipiId { get; set; }

        // Navigation properties
        public virtual Kullanici Kullanici { get; set; }
        public virtual SensorVeriTipi SensorVeriTipi { get; set; }
    }
}
