using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PMS.Harrier.BusinessLogicLayer.Abstract;
using PMS.Harrier.DataAccessLayer.Models;
using PMS.Harrier.DataAccessLayer.ViewModels.ProjectViewModels;
using PMS.Harrier.WebUI.ViewModels;

namespace PMS.Harrier.WebUI.Controllers
{
    public class DevelopersController : Controller
    {

        private readonly IDeveloperLogic _developerLogic;

        public DevelopersController(IDeveloperLogic developerLogic)
        {
            _developerLogic = developerLogic;
            AutoMapper.Mapper
                .CreateMap<Developer, DeveloperViewModel>()
                .ForMember(dest => dest.FirstName, opts => opts.MapFrom(src => src.Account.FirstName))
                .ForMember(dest => dest.LastName, opts => opts.MapFrom(src => src.Account.LastName))
                .ForMember(dest => dest.Email, opts => opts.MapFrom(src => src.Account.Email));
            AutoMapper.Mapper.CreateMap<DeveloperViewModel, Developer>();
            AutoMapper.Mapper.CreateMap<ProjectDeveloperViewModel, Developer>();
        }

        // GET: Developers
        public ActionResult Index()
        {
            var developers = _developerLogic.GetAllDevelopers();
            return View(AutoMapper.Mapper.Map<List<Developer>, List<DeveloperViewModel>>(developers));
        }

        // GET: Developers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var developer = _developerLogic.GetDeveloper(id.Value);
            if (developer == null)
            {
                return HttpNotFound();
            }

            return View(AutoMapper.Mapper.Map<Developer, DeveloperViewModel>(developer));
        }
        
        // GET: Developers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var developer = _developerLogic.GetDeveloper(id.Value);
            if (developer == null)
            {
                return HttpNotFound();
            }
            return View(AutoMapper.Mapper.Map<Developer, DeveloperViewModel>(developer));
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DeveloperId,ExperienceFromDate,CostPerHour,WeekAvailability")] DeveloperViewModel developer)
        {
            throw new NotImplementedException("TODO");
            //return RedirectToAction("Index");
        }
    }
}
