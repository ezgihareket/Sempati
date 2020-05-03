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
    public class HayvanHastaliklariController : Controller
    {
        private readonly ILogger<HayvanHastaliklariController> _logger;
        private readonly BarinakContext _db;
        public HayvanHastaliklariController(ILogger<HayvanHastaliklariController> logger, BarinakContext db)
        {
            _logger = logger;
            _db = db;
        }
        public IActionResult Index()
        {
            var list = _db.hayvan_hastaliklari.OrderBy(o=>o.hastalik_id).ToList();
            return View(list);
        }

        public IActionResult Olustur()
        {
            return View(new hayvan_hastaliklari());
        }

        public IActionResult Duzenle(int id)
        {
             var item =_db.hayvan_hastaliklari.Find(id);
            return View("Olustur",item);
            
        }

        
        public IActionResult Sil(int id)
        {
            var item = _db.hayvan_hastaliklari.Find(id);
            _db.hayvan_hastaliklari.Remove(item);
            _db.SaveChanges();
            return RedirectToAction("Index");
            
        }
        [HttpPost]
        public IActionResult Kaydet(hayvan_hastaliklari model)
        {
            try
            {
                if(model.hastalik_id==0){
                     _db.hayvan_hastaliklari.Add(model);//kullaniciyi kaydet
                }else{
                     _db.hayvan_hastaliklari.Update(model);
                }
               _db.SaveChanges();//yapılan değişiklikleri kaydet
                return Redirect("/hayvanhastaliklari/Index");// barinak adresine yönlendir.
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }
    }
}
