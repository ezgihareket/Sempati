using System.ComponentModel.DataAnnotations;

namespace Sempati.Models.Database
{
    public class stok
    {
        [Key]
        public int stok_id { get; set; }
        public int adet { get; set; }
        public string yiyecek { get; set; }
        public int yiyecek_id { get; set; }
    }
}