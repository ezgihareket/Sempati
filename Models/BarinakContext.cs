using System.Collections.Generic;
using Sempati.Models.Database;
using Microsoft.EntityFrameworkCore;

namespace Sempati.Models
{
    public class BarinakContext : DbContext
    {
        private static BarinakContext _context = null;
        private BarinakContext(){

        }
        public BarinakContext(DbContextOptions<BarinakContext> options){

        }
        public DbSet<Kullanici> kullanici { get; set; }
        public DbSet<hayvan_cinsleri> hayvan_cinsleri { get; set; }
        public DbSet<hayvan_hastaliklari> hayvan_hastaliklari { get; set; }
        public DbSet<hayvan_yiyecek_tipleri> hayvan_yiyecek_tipleri { get; set; }
        public DbSet<hayvanlar> hayvanlar { get; set; }
        public DbSet<iletisim> iletisim { get; set; }
        public DbSet<stok> stok { get; set; }

        public static BarinakContext getContext(){
            if (_context == null)
            {
                _context = new BarinakContext();
            }
            return _context;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("User ID=postgres;Password=1234;Server=localhost;Port=5432;Database=barinak;");
            }
        }










        // public BarinakContext(DbContextOptions options) : base(options)
        // {

        // }
        // public DbSet<Kullanici> kullanici { get; set; }
        // public DbSet<hayvan_cinsleri> hayvan_cinsleri { get; set; }


        // public DbSet<hayvan_hastaliklari> hayvan_hastaliklari { get; set; }
        // public DbSet<hayvan_yiyecek_tipleri> hayvan_yiyecek_tipleri { get; set; }

        // public DbSet<hayvanlar> hayvanlar { get; set; }
        // public DbSet<iletisim> iletisim { get; set; }
        // public DbSet<stok> stok { get; set; }
    }


}