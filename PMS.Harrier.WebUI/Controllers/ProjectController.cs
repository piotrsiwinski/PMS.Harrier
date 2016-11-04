using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PMS.Harrier.BusinessLogicLayer.Abstract;
using PMS.Harrier.DataAccessLayer.Models;

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

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Project project)
        {
            if (!ModelState.IsValid)
                return View(project);
            
            project.CreationDateTime = DateTime.Now;
            _projectLogic.AddNewProject(project);
            return RedirectToAction("Index");
        }

        public JsonResult ValidateProjectName(string name)
        {
            var result = _projectLogic.IsProjectNameAvailable(name);
            return result ? Json(true, JsonRequestBehavior.AllowGet) : Json("Projekt o takiej nazwie już istnieje", JsonRequestBehavior.AllowGet);
        }

        
    }
}