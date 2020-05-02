using System.ComponentModel.DataAnnotations;

namespace Sempati.Models.Database
{
    public class hayvan_yiyecek_tipleri
    {
        [Key]
        public int yiyecek_id { get; set; }
        public string aciklama { get; set; }
    }
}