using System.ComponentModel.DataAnnotations;

namespace Sempati.Models.Database
{
    public class Kullanici
    {
        [Key]
        public int kullanici_id { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }

        public string email { get; set; }
        public string sifre { get; set; }

        public string sehir { get; set; }

        public bool admin { get; set;}=false;
    }
}