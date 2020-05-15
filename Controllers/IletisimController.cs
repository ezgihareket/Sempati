using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Mail;
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
        public IActionResult Gonder(iletisim model)
        {
            IMail mail = new GenelMail();
            mail = new ImzaDecorator(mail);
            mail.Gonder(model);
            return Json(true);

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
