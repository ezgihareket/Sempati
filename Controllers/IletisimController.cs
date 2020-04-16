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
    public class IletisimController : Controller
    {
        BarinakContext _db;
        public IletisimController(BarinakContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Kaydet(iletisim model)
        {
                _db.iletisim.Add(model);
                _db.SaveChanges();//yapılan değişiklikleri kaydet
                return Redirect("/iletisim");
            
        }
    }
}
