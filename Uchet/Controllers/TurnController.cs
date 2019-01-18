using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Uchet.Models;
using System.Data.Entity;

namespace Uchet.Controllers
{
    public class TurnController : Controller
    {
        Context db = new Context();

        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.Message = "Расход";
            List<Turn> turnList = new List<Turn>();
            var loadDb = db.Nomenclature;
            foreach (var item in loadDb)
            {
                turnList.Add(new Turn()
                {
                    Id = item.Id,
                    Name = item.Name,
                    Sort = item.Sort,
                    Unit = item.Unit
                });
            }
            for (var i = 0; i < turnList.Count; i++)
            {
                //Собираем отгрузку
                var id = turnList[i].Id;
                var idBDp = db.Profit.Where(l => l.Nomenclature == id);
                foreach (var item in idBDp)
                {
                    turnList[i].Profit += item.Quantity;
                }
                //Собираем загрузку
                id = turnList[i].Id;
                var idBDe = db.Expense.Where(l => l.Nomenclature == id);
                foreach (var item in idBDe)
                {
                    turnList[i].Exspense += item.Quantity;
                }
                //Считаем разность
                turnList[i].Balance = turnList[i].Profit - turnList[i].Exspense;
            }
            //Отдаем на выдачу
            ViewBag.Turn = turnList;
            return View();
        }
    }
}