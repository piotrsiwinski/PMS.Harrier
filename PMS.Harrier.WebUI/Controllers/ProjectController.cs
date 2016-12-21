﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PMS.Harrier.BusinessLogicLayer.Abstract;
using PMS.Harrier.DataAccessLayer.Models;
using PMS.Harrier.DataAccessLayer.ViewModels.ProjectViewModels;

namespace PMS.Harrier.WebUI.Controllers
{
    [Authorize]
    public class ProjectController : Controller
    {
        private readonly IProjectLogic _projectLogic;
        private readonly IDeveloperLogic _developerLogic;

        public ProjectController(IProjectLogic projectLogic, IDeveloperLogic developerLogic)
        {
            _projectLogic = projectLogic;
            _developerLogic = developerLogic;
        }

        // GET: Project
        public ActionResult Index()
        {
            var result = _projectLogic.GetAllProjects();
            return View(result);
        }

        public ActionResult AddDeveloperToProject(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var project = _projectLogic.GetProject(id.Value);
            var developers = _developerLogic.GetAllDevelopers();
            var model =
                developers.Select(
                    n =>
                        new ProjectDeveloperViewModel
                        {
                            ProjectId = project.ProjectId,
                            DeveloperId = n.DeveloperId,
                            FirstName = n.FirstName,
                            LastName = n.LastName
                        }).ToList();
            return View(model);
        }
        [HttpPost]
        public ActionResult AddDeveloperToProject(List<ProjectDeveloperViewModel> developers)
        {
            if (ModelState.IsValid)
            {
                _projectLogic.AddDevelopersToProject(developers.Where(n => n.IsSelected).ToList());
                return RedirectToAction("Index");
            }
            return View(developers);

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
            
            project.StartDate = DateTime.Now;
            _projectLogic.AddNewProject(project);
            return RedirectToAction("Index");
        }

        public JsonResult ValidateProjectName(string name)
        {
            var result = _projectLogic.IsProjectNameAvailable(name);
            return result 
                ? Json(true, JsonRequestBehavior.AllowGet) 
                : Json("Projekt o takiej nazwie już istnieje", JsonRequestBehavior.AllowGet);
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var project = _projectLogic.GetProject(id.Value);
            if (project == null)
            {
                return HttpNotFound();
            }
            return View(project);
        }

        
    }
}