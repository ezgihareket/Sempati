using System;

namespace Sempati.Models.Database
{
    public class hayvan_gecmisi
    {
        public int gecmis_id { get; set; }
        public DateTime giris_tarihi { get; set; }
        public string aciklama { get; set; }
        public int hayvan_id { get; set; }
    }
}