using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Uchet.Controllers
{
    abstract class ReportDate
    {
        private string name;
        private int age;
        public int Age
        {
            set
            {
                if (value < 18)
                {
                    Console.WriteLine("Возраст должен быть больше 17");
                }
                else
                {
                    age = value;
                }
            }
            get { return age; }
        }

        int Sum(int a, int b)
        { return a + b; }

        double Sum(double a, double b)
        { return a + b; }
    }

    public class NegotiableStatementController : Controller
    {
        // GET: NegotiableStatement
        public ActionResult Index()
        {
            return View();
        }
    }
}