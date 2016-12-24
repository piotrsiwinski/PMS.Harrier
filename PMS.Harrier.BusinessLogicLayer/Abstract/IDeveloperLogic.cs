using System.Collections.Generic;
using PMS.Harrier.DataAccessLayer.Models;
using PMS.Harrier.DataAccessLayer.ViewModels.ProjectViewModels;

namespace PMS.Harrier.BusinessLogicLayer.Abstract
{
    public interface IDeveloperLogic
    {
        List<Developer> GetAllDevelopers();
        Developer GetDeveloper(int id);
        void AddDeveloper(Developer developer);
    }
}