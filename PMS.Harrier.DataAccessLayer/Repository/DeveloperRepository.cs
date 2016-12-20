

using System;
using System.Collections.Generic;
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
            AutoMapper.Mapper.CreateMap<Developer, DeveloperViewModel>();
        }

        public List<DeveloperViewModel> GetAllDevelopers()
        {
            var developers =  Context.Developers.ToList();
            var result = AutoMapper.Mapper.Map<List<Developer>, List<DeveloperViewModel>>(developers);
            return result;
        }
    }
}