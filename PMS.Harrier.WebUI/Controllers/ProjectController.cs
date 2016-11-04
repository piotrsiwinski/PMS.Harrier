using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PMS.Harrier.BusinessLogicLayer.Abstract;

namespace PMS.Harrier.WebUI.Controllers
{
    public class ProjectController : Controller
    {
        private IProjectLogic _projectLogic;

        public ProjectController(IProjectLogic projectLogic)
        {
            _projectLogic = projectLogic;
        }

        // GET: Project
        public ActionResult Index()
        {
            var result = _projectLogic.GetAllProjects();
            return View(result);
        }
    }
}