using System.Collections.Generic;
using PMS.Harrier.DataAccessLayer.Models;

namespace PMS.Harrier.DataAccessLayer.Repository
{
    public interface IProjectRepository
    {
        IEnumerable<Project> Projects { get;}
        void AddProject(Project project);
        Project DeleteProject(int projectId);

    }
}