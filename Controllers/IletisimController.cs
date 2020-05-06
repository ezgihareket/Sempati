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
    public class IletisimController : Controller
    {
        private BarinakContext _db;
      
        public IActionResult Index()
        {
            return View();
        }

        //Veritabanında ki iletişim tablosuna girilen verileri kaydeden methot
        [HttpPost]
        public IActionResult Kaydet(iletisim model)
        {
                getDb().iletisim.Add(model);
            getDb().SaveChanges();//yapılan değişiklikleri kaydet
                return Redirect("/iletisim");//İletişim sayfasına yönlendir
            
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
