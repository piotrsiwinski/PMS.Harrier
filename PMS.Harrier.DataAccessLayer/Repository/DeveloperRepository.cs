﻿using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using PMS.Harrier.DataAccessLayer.Concrete;
using PMS.Harrier.DataAccessLayer.Models;
using PMS.Harrier.DataAccessLayer.Repository.AbstractRepository;
using PMS.Harrier.DataAccessLayer.Repository.Interfaces;
using PMS.Harrier.DataAccessLayer.ViewModels.ProjectViewModels;

namespace PMS.Harrier.DataAccessLayer.Repository
{
    public class DeveloperRepository : Repository<Developer>, IDeveloperRepository
    {
        public DeveloperRepository(EfDbContext context) : base(context)
        {
            AutoMapper.Mapper
                .CreateMap<Developer, DeveloperViewModel>()
                .ForMember(dest => dest.FirstName, opts => opts.MapFrom(src => src.Account.FirstName))
                .ForMember(dest => dest.LastName, opts => opts.MapFrom(src => src.Account.LastName))
                .ForMember(dest => dest.Email, opts => opts.MapFrom(src => src.Account.Email));
            AutoMapper.Mapper.CreateMap<DeveloperViewModel, Developer>();
            AutoMapper.Mapper.CreateMap<ProjectDeveloperViewModel, Developer>();
        }

        public List<DeveloperViewModel> GetAllDevelopers()
        {
            var developers =  Context.Developers.ToList();
            return AutoMapper.Mapper.Map<List<Developer>, List<DeveloperViewModel>>(developers);
        }

        public DeveloperViewModel GetDeveloper(int id)
        {
            var developer = Context.Developers.FirstOrDefault(d => d.DeveloperId == id);
            return AutoMapper.Mapper.Map<Developer, DeveloperViewModel>(developer);
        }

        public void AddDeveloper(DeveloperViewModel developerViewModel)
        {
            var developer = AutoMapper.Mapper.Map<DeveloperViewModel, Developer>(developerViewModel);
            Context.Entry(developer).State = EntityState.Modified;
            Context.SaveChanges();

//            var entity = Context.Developers.Find(developer.DeveloperId);
//            Context.Developers.Add(entity);

        }

        public void AddDevelopersToProject(List<ProjectDeveloperViewModel> developers)
        {
//            var devs = AutoMapper.Mapper.Map<List<ProjectDeveloperViewModel>, List<Developer>>(developers);

            var result =
                developers.Select(n => new ProjectDeveloper {DeveloperId = n.DeveloperId, ProjectId = n.ProjectId});
            Context.ProjectDeveloper.AddRange(result);
            Context.SaveChanges();

        }
    }
}