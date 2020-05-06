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
        private BarinakContext _db;
     
        public IActionResult Index()
        {
            var list = getDb().hayvanlar.ToList();
            return View(list);
        }


        public IActionResult Olustur()
        {
            ViewBag.HayvanCinsleri = getDb().hayvan_cinsleri.ToList();
            return View(new hayvanlar());
        }
        public IActionResult Duzenle(int id)
        {
            ViewBag.HayvanCinsleri = getDb().hayvan_cinsleri.ToList();
            var item =getDb().hayvanlar.Find(id);
            return View("Olustur",item);
        }
        
        public IActionResult Sil(int id)
        {
            var item = getDb().hayvanlar.Find(id);
            getDb().hayvanlar.Remove(item);
            getDb().SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Kaydet(hayvanlar model)
        {
            try
            {
                if(model.hayvan_id==0){
                     getDb().hayvanlar.Add(model);
                }else{
                    getDb().hayvanlar.Update(model);
                }
                getDb().SaveChanges();//yapılan değişiklikleri kaydet
                return Redirect("/hayvanlar/Index"); //Hayvanlar içindeki index.cshtml adresine yönlendir.
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
