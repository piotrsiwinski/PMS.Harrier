using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PMS.Harrier.DataAccessLayer.Concrete;
using PMS.Harrier.DataAccessLayer.Repository;
using PMS.Harrier.DataAccessLayer.UnitOfWork;

namespace PMS.Harrier.WebUI.Tests
{
    [TestClass]
    public class TestClass
    {
        [TestMethod]
        public void Test()
        {
            IUnitOfWork unitOfWork = new UnitOfWork(new EfDbContext());
            var result = unitOfWork.Projects.GetAllProjects();

        }
    }
}