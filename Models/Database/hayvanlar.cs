
using System.ComponentModel.DataAnnotations;

namespace Sempati.Models.Database
{
    public class hayvanlar
    {
        [Key]
        public int hayvan_id { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string cinsiyet { get; set; }
        public string tip { get; set; }
        public int yas { get; set; }
        public int agirlik { get; set; }
        public string renk { get; set; }
        public int tasma_no { get; set; }
        public int kafes_no { get; set; }
        public string resim { get; set; }
        public int cins_id { get; set; }
    }
}