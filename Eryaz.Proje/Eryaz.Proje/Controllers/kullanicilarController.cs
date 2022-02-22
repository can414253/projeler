using Eryaz.Proje.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Eryaz.Proje.Controllers
{
    public class kullanicilarController : Controller
    {
        MVCEntities baglanti = new MVCEntities();

        public ActionResult kullanici()
        {

            List<kullanici> liste = baglanti.kullanici.ToList();
            return View();
        }
    }
}