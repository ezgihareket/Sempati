﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sempati.Controllers
{
    public class ImzaDecorator : Decorator
    {
               

        public ImzaDecorator(IMail mail) : base(mail)
        {
        }

    /*    public bool Gonder(iletisim model)
        {
            string mailto = "ezgihareket@gmail.com";
            string subject = "İletişim";
            string text = model.mesaj;
            string sender = "sempatibarinak@gmail.com";
            MailMessage msg = new MailMessage(sender, mailto, subject, text);
            msg.IsBodyHtml = true;
            SmtpClient sc = new SmtpClient("smtp.gmail.com", 587);
            sc.UseDefaultCredentials = false;
            NetworkCredential cre = new NetworkCredential(sender, "Sempati2811");
            sc.Credentials = cre;
            sc.EnableSsl = true;
            sc.Send(msg);

            return true;
        }*/
    }
}
