using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Sempati.Models;
using Sempati.Models.Database;

namespace Sempati.Controllers
{
    public class HayvanCinsleriController : Controller
    {
        private BarinakContext _db;
      


        public async Task<IActionResult> Index(string searchString)
        {

            var cins = from c in getDb().hayvan_cinsleri
                       select c;

            if (String.IsNullOrEmpty(searchString))
            {
                var list = getDb().hayvan_cinsleri.OrderBy(o => o.cins_id).ToList();
                return View(list);
               
            }else{
                 cins = cins.Where(s => s.adi.Contains(searchString));
                 return View(await cins.ToListAsync());
            }

        }


        public IActionResult Olustur()
        {
            return View(new hayvan_cinsleri());
        }
        public IActionResult Duzenle(int id)
        {
            var item = getDb().hayvan_cinsleri.Find(id);
            return View("Olustur", item);
        }
        public IActionResult Sil(int id)
        {
            var item = getDb().hayvan_cinsleri.Find(id);
            getDb().hayvan_cinsleri.Remove(item);
            getDb().SaveChanges();
            return RedirectToAction("Index");
            
        }
        [HttpPost]
        public IActionResult Kaydet(hayvan_cinsleri model)
        {
            try
            {
                if (model.cins_id == 0)
                {
                    getDb().hayvan_cinsleri.Add(model);//kullaniciyi kaydet
                }
                else
                {
                    getDb().hayvan_cinsleri.Update(model);//kullaniciyi 
                }
                getDb().SaveChanges();//yapılan değişiklikleri kaydet
                return Redirect("/hayvancinsleri/Index");// barinak adresine yönlendir.
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
