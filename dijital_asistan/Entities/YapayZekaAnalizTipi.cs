using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dijital_asistan.Entities
{
    public class YapayZekaAnalizTipi
    {
        [Key] // Anahtar olarak belirtmek
        public int AnalizTipiId { get; set; }

        [Required] // Zorunlu alan
        [StringLength(100)] // Maksimum uzunluk sınırı
        public string AnalizTipiAdi { get; set; }

        [StringLength(500)] // Maksimum uzunluk sınırı
        public string Sonuc { get; set; }

        public DateTime OlusturulmaTarihi { get; set; }

        // Navigation property
        public ICollection<YapayZekaAnaliz> YapayZekaAnalizler { get; set; }
    }
}
