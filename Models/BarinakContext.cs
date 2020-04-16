using System.Collections.Generic;
using Sempati.Models.Database;
using Microsoft.EntityFrameworkCore;

namespace Sempati.Models
{
    public class BarinakContext : DbContext
    {
        public BarinakContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Kullanici> kullanici { get; set; }
        public DbSet<hayvan_cinsleri> hayvan_cinsleri { get; set; }


        public DbSet<hayvan_hastaliklari> hayvan_hastaliklari { get; set; }
        public DbSet<hayvan_yiyecek_tipleri> hayvan_yiyecek_tipleri { get; set; }

        public DbSet<hayvanlar> hayvanlar { get; set; }
        public DbSet<iletisim> iletisim { get; set; }
    }


}