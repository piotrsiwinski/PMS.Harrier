using System.Collections.Generic;
using PMS.Harrier.DataAccessLayer.Models;

namespace PMS.Harrier.DataAccessLayer.Repository.Interfaces
{
    public interface IDeveloperRepository
    {
        List<Developer> GetAllDevelopers();
        Developer Get(int id);

    }
}