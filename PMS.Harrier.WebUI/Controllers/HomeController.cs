using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using PMS.Harrier.BusinessLogicLayer.Abstract;
using PMS.Harrier.DataAccessLayer.Models;
using PMS.Harrier.WebUI.ViewModels;

namespace PMS.Harrier.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProjectLogic _projectLogic;

        public HomeController(IProjectLogic projectLogic)
        {
            AutoMapper.Mapper.CreateMap<Project, ProjectViewModel>();
            _projectLogic = projectLogic;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
        [ChildActionOnly]
        public ActionResult MyProjects()
        {
            var loggedUser =
                System.Web.HttpContext.Current.GetOwinContext()
                    .GetUserManager<ApplicationUserManager>()
                    .FindById(System.Web.HttpContext.Current.User.Identity.GetUserId());
            var userProjects = _projectLogic.GetProjectsByDeveloperId(loggedUser.Developer.DeveloperId);
            return PartialView("_myProjects",AutoMapper.Mapper.Map<List<Project>, List<ProjectViewModel>>(userProjects));
        }
    }
}