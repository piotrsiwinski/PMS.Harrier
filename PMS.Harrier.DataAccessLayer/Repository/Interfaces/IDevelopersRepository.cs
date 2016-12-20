using System.Collections.Generic;
using PMS.Harrier.DataAccessLayer.Models;
using PMS.Harrier.DataAccessLayer.Repository.AbstractRepository;
using PMS.Harrier.DataAccessLayer.ViewModels.ProjectViewModels;

namespace PMS.Harrier.DataAccessLayer.Repository.Interfaces
{
    public interface IDeveloperRepository : IRepository<Developer>
    {
        List<DeveloperViewModel> GetAllDevelopers();
        DeveloperViewModel GetDeveloper(int id);

    }
}