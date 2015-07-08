using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zavod.Models;

namespace Zavod.Controllers
{
    public class HomeController : Controller
    {
        // создаем контекст данных
        WorkerContext db = new WorkerContext();

        public ActionResult Index()
        {
           
            return View();
        }
        public ActionResult Workers()
        {
            // получаем из бд все обьекты Worker
            IEnumerable<Worker> workers = db.Workers;
            // передаем все обьекты в динамическое св-во ViewBag
            ViewBag.Workers = workers;
            return View();
        }
    }
}