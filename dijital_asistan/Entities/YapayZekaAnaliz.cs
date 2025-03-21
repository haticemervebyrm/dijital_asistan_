using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dijital_asistan.Entities
{
    public class YapayZekaAnaliz
    {
        [Key] // Anahtar olarak belirtmek
        public int AnalizId { get; set; }

        [ForeignKey("KullaniciId")] // Kullanıcı ID ile ilişkilendir
        public int KullaniciId { get; set; }

        [ForeignKey("AnalizTipiId")] // Analiz tipi ID ile ilişkilendir
        public int AnalizTipiId { get; set; }

        // Navigation properties (İlişki kurulan tablolar)
        public Kullanici Kullanici { get; set; }
        public YapayZekaAnalizTipi AnalizTipi { get; set; }
    }
}
