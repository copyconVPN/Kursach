using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Uchet.Controllers
{
    public class NomenclatureController : Controller
    {
        // GET: Nomenclature
        public ActionResult Index()
        {
            ViewBag.Message = "Номенклатура";
            return View();
        }
    }
}