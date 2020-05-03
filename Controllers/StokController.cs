using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Sempati.Filter;
using Sempati.Models;
using Sempati.Models.Database;

namespace Sempati.Controllers
{
    [KullaniciFilter]
    public class StokController : Controller
    {
        private readonly ILogger<StokController> _logger;
        private readonly BarinakContext _db;
        public StokController(ILogger<StokController> logger, BarinakContext db)
        {
            _logger = logger;
            _db = db;
        }
        public IActionResult Index()
        {
            var list = _db.stok.ToList();
            return View(list);
        }


        public IActionResult Olustur()
        {
            ViewBag.HayvanYiyecekTipleri = _db.hayvan_yiyecek_tipleri.ToList();
            return View(new stok());
        }
        public IActionResult Duzenle(int id)
        {
            ViewBag.HayvanYiyecekTipleri = _db.hayvan_yiyecek_tipleri.ToList();
            var item = _db.stok.Find(id);
            return View("Olustur", item);
        }

        public IActionResult Sil(int id)
        {
            var item = _db.stok.Find(id);
            _db.stok.Remove(item);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Kaydet(stok model)
        {
            try
            {
                if (model.stok_id == 0)
                {
                    _db.stok.Add(model);
                }
                else
                {
                    _db.stok.Update(model);
                }
                _db.SaveChanges();//yapılan değişiklikleri kaydet
                return Redirect("/stok/Index"); //Hayvanlar içindeki index.cshtml adresine yönlendir.
            }
            catch (System.Exception ex)
            {

                throw;
            }
        }
    }
}
