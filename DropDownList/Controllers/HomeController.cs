using DropDownList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DropDownList.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult DatabaseExample()
        {
            DropDownListEntities db = new DropDownListEntities();
            var list = db.fruits.ToList();
            SelectList selectListItems = new SelectList(list ,"id","name");
            ViewBag.baglist = selectListItems;
            return View();

        }

    }
}