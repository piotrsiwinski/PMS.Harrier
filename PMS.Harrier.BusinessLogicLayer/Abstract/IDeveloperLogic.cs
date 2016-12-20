using System.Collections.Generic;
using PMS.Harrier.DataAccessLayer.Models;

namespace PMS.Harrier.BusinessLogicLayer.Abstract
{
    public interface IDeveloperLogic
    {
        List<Developer> GetAllDevelopers();
        Developer Get(int id);
    }
}