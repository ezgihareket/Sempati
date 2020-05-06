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
        private BarinakContext _db;
       
        public IActionResult Index()
        {
            var list = getDb().hayvan_hastaliklari.OrderBy(o=>o.hastalik_id).ToList();
            return View(list);
        }

        public IActionResult Olustur()
        {
            return View(new hayvan_hastaliklari());
        }

        public IActionResult Duzenle(int id)
        {
             var item =getDb().hayvan_hastaliklari.Find(id);
            return View("Olustur",item);
            
        }

        
        public IActionResult Sil(int id)
        {
            var item = getDb().hayvan_hastaliklari.Find(id);
            getDb().hayvan_hastaliklari.Remove(item);
            getDb().SaveChanges();
            return RedirectToAction("Index");
            
        }
        [HttpPost]
        public IActionResult Kaydet(hayvan_hastaliklari model)
        {
            try
            {
                if(model.hastalik_id==0){
                     getDb().hayvan_hastaliklari.Add(model);//kullaniciyi kaydet
                }else{
                     getDb().hayvan_hastaliklari.Update(model);
                }
               getDb().SaveChanges();//yapılan değişiklikleri kaydet
                return Redirect("/hayvanhastaliklari/Index");// barinak adresine yönlendir.
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
