using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PMS.Harrier.DataAccessLayer.Repository;

namespace PMS.Harrier.WebUI.Tests
{
    [TestClass]
    public class TestClass
    {
        [TestMethod]
        public void Test()
        {
            IProjectRepository repository = new ProjectRepository();
            var projects = repository.Projects.ToList();

        }
    }
}