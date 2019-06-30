using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAreasDemo.Areas.SuperUser.Controllers
{
    public class DefaultController : Controller
    {
        // GET: SuperUser/Default
        public ActionResult Index()
        {
            return View();
        }
    }
}