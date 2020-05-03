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
         private readonly ILogger<IletisimController> _logger;
        private readonly BarinakContext _db;
        public IletisimController(ILogger<IletisimController> logger, BarinakContext db)
        {
            _logger = logger;
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }

        //Veritabanında ki iletişim tablosuna girilen verileri kaydeden methot
        [HttpPost]
        public IActionResult Kaydet(iletisim model)
        {
                _db.iletisim.Add(model);
                _db.SaveChanges();//yapılan değişiklikleri kaydet
                return Redirect("/iletisim");//İletişim sayfasına yönlendir
            
        }
    }
}
