using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using PMS.Harrier.BusinessLogicLayer.Abstract;
using PMS.Harrier.DataAccessLayer.Concrete;
using PMS.Harrier.DataAccessLayer.Models;
using PMS.Harrier.DataAccessLayer.ViewModels.ProjectViewModels;
using PMS.Harrier.WebUI.ViewModels;

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
            AutoMapper.Mapper.CreateMap<Project, ProjectViewModel>();
            AutoMapper.Mapper
               .CreateMap<Developer, AddDeveloperViewModel>()
               .ForMember(dest => dest.FirstName, opts => opts.MapFrom(src => src.Account.FirstName))
               .ForMember(dest => dest.LastName, opts => opts.MapFrom(src => src.Account.LastName))
               .ForMember(dest => dest.DeveloperId, opts => opts.MapFrom(src => src.DeveloperId));

            AutoMapper.Mapper.CreateMap<AddDeveloperViewModel, ProjectDeveloper>();
        }
        // GET: Project
        public ActionResult Index()
        {
            var projects = _projectLogic.GetAllProjects();
            return View(AutoMapper.Mapper.Map<List<Project>, List<ProjectViewModel>>(projects));
            
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

        public ActionResult Edit(int? id)
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
            return View(AutoMapper.Mapper.Map<Project, ProjectViewModel>(project));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ProjectViewModel project)
        {
            if (ModelState.IsValid)
            {
                //update entity in db
                return RedirectToAction("Index");
            }
            return View(project);
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

            return View(AutoMapper.Mapper.Map<Project, ProjectViewModel>(project));
        }

        public ActionResult MyProjects()
        {
            var loggedUser = System.Web.HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>().FindById(System.Web.HttpContext.Current.User.Identity.GetUserId());

            var result = loggedUser.Developer.ProjectDeveloper.Where(n => n.DeveloperId == loggedUser.Developer.DeveloperId).Select(n => n.Project);

            return View(result);
        }

        public JsonResult ValidateProjectName(string projectName)
        {
            var result = _projectLogic.IsProjectNameAvailable(projectName);
            return result
                ? Json(true, JsonRequestBehavior.AllowGet)
                : Json("Projekt o takiej nazwie już istnieje", JsonRequestBehavior.AllowGet);
        }
        public ActionResult AddDeveloperToProject(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            
            var project = _projectLogic.GetProject(id.Value);
            var result = AutoMapper.Mapper.Map<List<Developer>, List<AddDeveloperViewModel>>(_developerLogic.GetAllDevelopers());
            result.ForEach(n => n.ProjectId = project.ProjectId);

            return View(result);
        }
        [HttpPost]
        public ActionResult AddDeveloperToProject([Bind(Include = "DeveloperId,ProjectId, IsSelected")] List<AddDeveloperViewModel> selectedDevelopers)
        {
            if (ModelState.IsValid)
            {
                var result = AutoMapper.Mapper.Map<List<AddDeveloperViewModel>, List<ProjectDeveloper>>(selectedDevelopers.Where(n => n.IsSelected).ToList());
                _projectLogic.AddDevelopersToProject(result);
                return RedirectToAction("Index");
            }
            return View(selectedDevelopers);
        }
    }
}