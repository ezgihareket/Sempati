using System.ComponentModel.DataAnnotations;

namespace Sempati.Models.Database
{
    public class hayvan_cinsleri
    {
        [Key]
        public int cins_id { get; set; }
        public string adi { get; set; }
        public string aciklama { get; set; }

    }
}