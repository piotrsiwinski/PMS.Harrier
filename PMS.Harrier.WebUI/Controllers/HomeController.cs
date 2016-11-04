using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PMS.Harrier.BusinessLogicLayer.Abstract;

namespace PMS.Harrier.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private IProjectLogic _projectLogic;

        public HomeController(IProjectLogic projectLogic)
        {
            _projectLogic = projectLogic;
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}