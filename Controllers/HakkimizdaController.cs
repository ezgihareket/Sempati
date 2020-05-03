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
    public class HakkimizdaController : Controller
    {
        private readonly ILogger<HakkimizdaController> _logger;
        private readonly BarinakContext _db;
        public HakkimizdaController(ILogger<HakkimizdaController> logger, BarinakContext db)
        {
            _logger = logger;
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Kaydet(Kullanici model)
        {
            _db.kullanici.Add(model);//kullaniciyi kaydet
            _db.SaveChanges();//yapılan değişiklikleri kaydet
            return Redirect("/hakkimizda");// barinak adresine yönlendir.

        }
    }
}
