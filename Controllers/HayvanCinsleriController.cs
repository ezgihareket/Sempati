using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sempati.Models;
using Sempati.Models.Database;

namespace Sempati.Controllers
{
    public class HayvanCinsleriController : Controller
    {
        private readonly BarinakContext _db;
        public HayvanCinsleriController(BarinakContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var list = _db.hayvan_cinsleri.OrderBy(o => o.cins_id).ToList();
            return View(list);
        }
        public IActionResult Olustur()
        {
            return View(new hayvan_cinsleri());
        }
        public IActionResult Duzenle(int id)
        {
            var item = _db.hayvan_cinsleri.Find(id);
            return View("Olustur", item);
        }
        public IActionResult Sil(int id)
        {
            var item = _db.hayvan_cinsleri.Find(id);
            _db.hayvan_cinsleri.Remove(item);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Kaydet(hayvan_cinsleri model)
        {
            try
            {
                if (model.cins_id == 0)
                {
                    _db.hayvan_cinsleri.Add(model);//kullaniciyi kaydet
                }
                else
                {
                    _db.hayvan_cinsleri.Update(model);//kullaniciyi 
                }
                _db.SaveChanges();//yapılan değişiklikleri kaydet
                return Redirect("/hayvancinsleri/Index");// barinak adresine yönlendir.
            }
            catch (System.Exception ex)
            {

                throw;
            }
        }
    }
}
