using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Sempati.Models;
using Sempati.Models.Database;

namespace Sempati.Controllers
{
    public class HayvanYiyecekTipleriController : Controller
    {
         private readonly ILogger<HayvanYiyecekTipleriController> _logger;
        private readonly BarinakContext _db;
        public HayvanYiyecekTipleriController(ILogger<HayvanYiyecekTipleriController> logger, BarinakContext db)
        {
            _logger = logger;
            _db = db;
        }
        // BarinakContext _db;
        // public HayvanYiyecekTipleriController(BarinakContext db)
        // {
        //     _db = db;
        // }
        public IActionResult Index()
        {
            var list = _db.hayvan_yiyecek_tipleri.OrderBy(o=>o.yiyecek_id).ToList();
            return View(list);
        }

        //Hayvanlar için girilen bilgileri veritabınındaki tabloya oluşturmayı sağlar
        public IActionResult Olustur()
        {
            return View(new hayvan_yiyecek_tipleri());
        }

        //Girilen bilgileri düzenlememizi sağlar
        public IActionResult Duzenle(int id)
        {
            var item =_db.hayvan_yiyecek_tipleri.Find(id);
            return View("Olustur",item); //Oluştur.cshtml adresine yönlendirir
        }

        //Girilen bilgileri silmemizi sağlar
        public IActionResult Sil(int id)
        {
             var item = _db.hayvan_yiyecek_tipleri.Find(id);
            _db.hayvan_yiyecek_tipleri.Remove(item);
            _db.SaveChanges();
            return RedirectToAction("Index");  //index.cshtml adresine yönlendirir
        }
        [HttpPost]
        public IActionResult Kaydet(hayvan_yiyecek_tipleri model)
        {
            try
            {
                if(model.yiyecek_id==0){
                    _db.hayvan_yiyecek_tipleri.Add(model);
                }else{
                     _db.hayvan_yiyecek_tipleri.Update(model);
                }
               
                _db.SaveChanges();//yapılan değişiklikleri kaydet
                return Redirect("/hayvanyiyecektipleri/Index");//HayvanYiyecekTipleri içindeki index.cshtml adresine yönlendir.
            }
            catch (System.Exception ex)
            {
                
                throw;
            }
        }
    }
}
