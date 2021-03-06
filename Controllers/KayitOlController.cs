﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sempati.Models;
using Sempati.Models.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace Sempati.Controllers
{
    public class KayitOlController : Controller
    {
        private BarinakContext _db;
      
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Kaydet(Kullanici model)
        {
            getDb().kullanici.Add(model);//kullaniciyi kaydet
            getDb().SaveChanges();//yapılan değişiklikleri kaydet
            return Redirect("/Barinak");// barinak adresine yönlendir.
        }

        //Kayıt olduktan sonra sisteme giriş yapmak için kullanılan fonksiyon
        public async Task<IActionResult> GirisYap(string email, string sifre)
        {
            //Girilen emailve şifre ile kullanıcının email'i ve şifresi aynı ise Kullanıcı vardır
            var kullanici = await getDb().kullanici.FirstOrDefaultAsync(w => w.email == email && w.sifre == sifre);
            //Eşit değillerse kullanıcı null döner
            if (kullanici == null)
            {
                return Redirect("/");
            }
            HttpContext.Session.SetInt32("id", kullanici.kullanici_id);
            HttpContext.Session.SetString("kullanici_adi", kullanici.ad);
            //Girilien kullanıcı admin ise true değil ise false döner
            if (kullanici.admin)
            {
                HttpContext.Session.SetString("admin", "true");
            }
            else
            {
                HttpContext.Session.SetString("admin", "false");
            }
            return Redirect("/");
        }

        //Giriş yaptıktan sonra istenildiğinde Çıkış yapmak için kullanılan method
        public IActionResult cikisYap()
        {
            HttpContext.Session.Clear();
            return Redirect("/");//Anasayfaya yönlendirir
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
