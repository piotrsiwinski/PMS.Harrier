using System.Collections.Generic;
using PMS.Harrier.DataAccessLayer.Models;
using PMS.Harrier.DataAccessLayer.ViewModels.ProjectViewModels;

namespace PMS.Harrier.BusinessLogicLayer.Abstract
{
    public interface IDeveloperLogic
    {
        List<DeveloperViewModel> GetAllDevelopers();
        DeveloperViewModel Get(int id);
    }
}