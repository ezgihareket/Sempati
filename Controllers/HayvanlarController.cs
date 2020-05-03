using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Sempati.Models;
using Sempati.Models.Database;

namespace Sempati.Controllers
{
    public class HayvanlarController : Controller
    {
        private readonly ILogger<HayvanlarController> _logger;
        private readonly BarinakContext _db;
        public HayvanlarController(ILogger<HayvanlarController> logger, BarinakContext db)
        {
            _logger = logger;
            _db = db;
        }
        public IActionResult Index()
        {
            var list = _db.hayvanlar.ToList();
            return View(list);
        }


        public IActionResult Olustur()
        {
            ViewBag.HayvanCinsleri = _db.hayvan_cinsleri.ToList();
            return View(new hayvanlar());
        }
        public IActionResult Duzenle(int id)
        {
            ViewBag.HayvanCinsleri = _db.hayvan_cinsleri.ToList();
            var item =_db.hayvanlar.Find(id);
            return View("Olustur",item);
        }
        
        public IActionResult Sil(int id)
        {
            var item = _db.hayvanlar.Find(id);
            _db.hayvanlar.Remove(item);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Kaydet(hayvanlar model)
        {
            try
            {
                if(model.hayvan_id==0){
                     _db.hayvanlar.Add(model);
                }else{
                    _db.hayvanlar.Update(model);
                }
                _db.SaveChanges();//yapılan değişiklikleri kaydet
                return Redirect("/hayvanlar/Index"); //Hayvanlar içindeki index.cshtml adresine yönlendir.
            }
            catch (System.Exception ex)
            {
                
                throw;
            }
        }
    }
}
