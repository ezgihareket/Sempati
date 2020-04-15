
using System.ComponentModel.DataAnnotations;
namespace Sempati.Models.Database
{
    public class hayvan_hastaliklari
    {
        [Key]
        public int hastalik_id { get; set; }
        public string hastalik_adi { get; set; }
        public string bulasici { get; set; }
    }
}