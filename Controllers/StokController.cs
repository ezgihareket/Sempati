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
        private BarinakContext _db;
      
        public IActionResult Index()
        {
            var list = getDb().stok.ToList();
            return View(list);
        }


        public IActionResult Olustur()
        {
            ViewBag.HayvanYiyecekTipleri = getDb().hayvan_yiyecek_tipleri.ToList();
            return View(new stok());
        }
        public IActionResult Duzenle(int id)
        {
            ViewBag.HayvanYiyecekTipleri = getDb().hayvan_yiyecek_tipleri.ToList();
            var item = getDb().stok.Find(id);
            return View("Olustur", item);
        }

        public IActionResult Sil(int id)
        {
            var item = getDb().stok.Find(id);
            getDb().stok.Remove(item);
            getDb().SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Kaydet(stok model)
        {
            try
            {
                if (model.stok_id == 0)
                {
                    getDb().stok.Add(model);
                }
                else
                {
                    getDb().stok.Update(model);
                }
                getDb().SaveChanges();//yapılan değişiklikleri kaydet
                return Redirect("/stok/Index"); //Hayvanlar içindeki index.cshtml adresine yönlendir.
            }
            catch (System.Exception ex)
            {

                throw;
            }
        }
        public BarinakContext getDb()
        {
            if (_db == null)
            {
                _db = BarinakContext.getContext();
            }

            return _db;
        }
    }
}
