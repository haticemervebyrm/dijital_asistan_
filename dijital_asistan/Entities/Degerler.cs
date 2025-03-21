using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dijital_asistan.Entities
{
    public class Degerler
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DegerId { get; set; }

        [ForeignKey("Kullanici")]
        public int? KullaniciId { get; set; } // Nullable
        public virtual Kullanici? Kullanici { get; set; } // Nullable

        [ForeignKey("DegerTipi")]
        public int? DegerTipiId { get; set; } // Nullable
        public virtual DegerTipi? DegerTipi { get; set; } // Nullable

        public string? DegerListesi { get; set; }  // Nullable

        public string? TahlilSonuclari { get; set; }  // Nullable

        public DateTime? Tarih { get; set; } // Nullable
    }
}