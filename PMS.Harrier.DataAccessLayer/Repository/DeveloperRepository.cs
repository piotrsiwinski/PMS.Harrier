using System.Collections.Generic;
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
            
            AutoMapper.Mapper.CreateMap<ProjectDeveloperViewModel, Developer>();
        }

//        public void AddDeveloper(DeveloperViewModel developerViewModel)
//        {
//            var developer = AutoMapper.Mapper.Map<DeveloperViewModel, Developer>(developerViewModel);
//            Context.Entry(developer).State = EntityState.Modified;
//            Context.SaveChanges();
//        }

        public void AddDeveloper(Developer developerViewModel)
        {
            throw new System.NotImplementedException();
        }

        public void AddDevelopersToProject(List<ProjectDeveloperViewModel> developers)
        {
            var result =
                developers.Select(n => new ProjectDeveloper {DeveloperId = n.DeveloperId, ProjectId = n.ProjectId});
            Context.ProjectDeveloper.AddRange(result);
            Context.SaveChanges();

        }
    }
}